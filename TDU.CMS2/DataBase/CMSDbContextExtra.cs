using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDU.CMS2.DataModels;

namespace TDU.CMS2.DataBase
{
    public partial class CMSDbContext
    {
        object GetPrimaryKeyValue(DbEntityEntry entry)
        {
            var objectStateEntry = ((IObjectContextAdapter)this).ObjectContext.ObjectStateManager.GetObjectStateEntry(entry.Entity);
            return objectStateEntry.EntityKey.EntityKeyValues[0].Value;
        }
        public override int SaveChanges()
        {
            var modifiedEntities = ChangeTracker.Entries()
        .Where(p => p.State == EntityState.Modified).ToList();
            var now = DateTime.UtcNow;

            foreach (var change in modifiedEntities)
            {
                var entityName = change.Entity.GetType().Name;
                var primaryKey = GetPrimaryKeyValue(change);

                foreach (var prop in change.OriginalValues.PropertyNames)
                {
                    var originalValue = change.OriginalValues[prop].ToString();
                    var currentValue = change.CurrentValues[prop].ToString();
                    if (originalValue != currentValue)
                    {
                        var log = new ChangeLog()
                        {
                            EntityName = entityName,
                            PrimaryKeyValue = primaryKey.ToString(),
                            PropertyName = prop,
                            OldValue = originalValue,
                            NewValue = currentValue,
                            DateChanged = now,
                            UserName = Users.FirstOrDefault(u=>u.UserName == System.Security.Principal.WindowsIdentity.GetCurrent().Name.Split('\\').Last())?.ToString()
                        };
                        ChangeLogs.Add(log);
                    }
                }}
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                // Retrieve the error messages as a list of strings.
                var errorMessages = ex.EntityValidationErrors
                        .SelectMany(x => x.ValidationErrors)
                        .Select(x => x.ErrorMessage);

                // Join the list to a single string.
                var fullErrorMessage = string.Join("; ", errorMessages);

                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }
    }
}
