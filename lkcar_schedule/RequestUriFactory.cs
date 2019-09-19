namespace Snarkorel.lkcar_schedule
{
    public static class RequestUriFactory
    {
        //Common requests
        private static string CommonDaysRequestFormat = "http://lkcar.transport.mos.ru/ExternalService/api/schedule/days";
        private static string CommonSeasonsRequestFormat = "http://lkcar.transport.mos.ru/ExternalService/api/schedule/seasons";
        private static string CommonVehicleTypeRequestFormat = "http://lkcar.transport.mos.ru/ExternalService/api/schedule/vehicle-type";
        //Route-specific requests
        private static string RoutesRequestFormat = "http://lkcar.transport.mos.ru/ExternalService/api/schedule/route?vehicleTypeId={0}"; //vehicleTypeId = 700
        private static string RouteDaysRequestFormat = "http://lkcar.transport.mos.ru/ExternalService/api/schedule/day?routeId={0}";
        private static string RouteSeasonsRequestFormat = "http://lkcar.transport.mos.ru/ExternalService/api/schedule/season?routeId={0}";
        private static string DirectionRequestFormat = "http://lkcar.transport.mos.ru/ExternalService/api/schedule/direction?day={0}&routeId={1}"; //day WEEKDAYS, routeId = 160
        private static string StopsRequestFormat = "http://lkcar.transport.mos.ru/ExternalService/api/schedule/stop?day={0}&directionId={1}&routeId={2}&season={3}&vehicleTypeId={4}"; //WEEKDAYS, dirId = 1, routeId = 160, season = SUMMER, vehTId = 700
        private static string ScheduleRequestFormat = "http://lkcar.transport.mos.ru/ExternalService/api/schedule/?day={0}&directionId={1}&routeId={2}&season={3}&stopId={4}&vehicleTypeId={5}"; //WEEKDAYS, dirId = 1, routeId = 160, season = SUMMER, stop = 18142, vehTId = 700
        private static string RouteInfoRequestFormat = "http://lkcar.transport.mos.ru/ExternalService/api/schedule/route/{0}"; //return Route JSON, 160
        //Stop-specific request
        private static string StopInfoRequestFormat = "http://lkcar.transport.mos.ru/ExternalService/api/schedule/stop/{0}"; //returns Stop JSON, 18142
        //Schedule time of validity request
        private static string ValidityTimeRequestFormat = "http://lkcar.transport.mos.ru/ExternalService/api/schedule/time?day={0}&directionId={1}&routeId={2}&season={3}&vehicleTypeId={4}"; //WEEKDAYS, 1, 160, SUMMER, 700


    }
}
