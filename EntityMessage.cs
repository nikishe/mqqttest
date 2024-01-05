using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MqqtTest.Classes
{
    public class EntityMessage : TimeStampedMessage
    {
        public Guid EntityId { get; set; }
        public string EntityName { get; set; }

        #region Construction

        public EntityMessage(Guid entityId, string entityName)
        {
            EntityId = entityId;
            EntityName = entityName;
        }
        public EntityMessage(Guid entityId)
        {
            EntityId = entityId;
        }
        public EntityMessage()
        {
        }
        #endregion

    }
}
