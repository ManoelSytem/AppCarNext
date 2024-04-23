using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarNext.Helpes
{
    public enum XUberState
    {
        Initial,
        SearchingOrigin,
        SearchingDestination,
        CalculatingRoute,
        ChoosingRide,
        ConfirmingPickUp,
        ShowingXUberPass,
        ShowingHealthyMeasures,
        AssigningDriver,
        WaitingForDriver,
        TripInProgress,
        TripCompleted
    }
}
