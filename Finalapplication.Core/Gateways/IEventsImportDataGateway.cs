using System.Collections.Generic;
using System.Linq;

namespace Finalapplication.Core
{
    public interface IEventsImportDataGateway
    {


        void Insert(List<Event> eventsFromCsv);
    }
}