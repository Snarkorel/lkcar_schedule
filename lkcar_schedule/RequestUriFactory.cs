using Snarkorel.lkcar_schedule.enums;

namespace Snarkorel.lkcar_schedule
{
    public static class RequestUriFactory
    {
        private static string BaseRequest = "http://lkcar.transport.mos.ru/ExternalService/api/schedule/";
        //Common requests
        private static string CommonDaysRequestFormat = "days";
        private static string CommonSeasonsRequestFormat = "seasons";
        private static string CommonVehicleTypeRequestFormat = "vehicle-type";
        //Route-specific requests
        private static string RoutesRequestFormat = "route?vehicleTypeId={0}"; //vehicleTypeId = 700
        private static string RouteDayRequestFormat = "day?routeId={0}"; //current day
        private static string RouteDaysRequestFormat = "days?routeId={0}"; //all days of operation
        private static string RouteSeasonRequestFormat = "season?routeId={0}"; //current season
        private static string RouteSeasonsRequestFormat = "seasons?routeId={0}"; //all seasons
        private static string DirectionRequestFormat = "direction?day={0}&routeId={1}"; //day WEEKDAYS, routeId = 160
        private static string StopsRequestFormat = "stop?day={0}&directionId={1}&routeId={2}&season={3}&vehicleTypeId={4}"; //WEEKDAYS, dirId = 1, routeId = 160, season = SUMMER, vehTId = 700
        private static string ScheduleRequestFormat = "?day={0}&directionId={1}&routeId={2}&season={3}&stopId={4}&vehicleTypeId={5}"; //WEEKDAYS, dirId = 1, routeId = 160, season = SUMMER, stop = 18142, vehTId = 700
        private static string RouteInfoRequestFormat = "route/{0}"; //return Route JSON, 160
        //Stop-specific request
        private static string StopInfoRequestFormat = "stop/{0}"; //returns Stop JSON, 18142
        //Schedule time of validity request
        private static string ValidityTimeRequestFormat = "time?day={0}&directionId={1}&routeId={2}&season={3}&vehicleTypeId={4}"; //WEEKDAYS, 1, 160, SUMMER, 700

        private static string GetRequestUri(string request)
        {
            return BaseRequest + request;
        }

        public static string GetCommonDaysListUri()
        {
            return GetRequestUri(CommonDaysRequestFormat);
        }

        public static string GetCommonSeasonsListUri()
        {
            return GetRequestUri(CommonSeasonsRequestFormat);
        }

        public static string GetCommonVehicleTypesListUri()
        {
            return GetRequestUri(CommonVehicleTypeRequestFormat);
        }

        public static string GetRoutesListUri(VehicleType vehicleType)
        {
            return GetRequestUri(string.Format(RoutesRequestFormat, (int)vehicleType));
        }

        public static string GetRouteCurrentDayUri(int routeId)
        {
            return GetRequestUri(string.Format(RouteDayRequestFormat, routeId));
        }

        public static string GetRouteDaysListUri(int routeId)
        {
            return GetRequestUri(string.Format(RouteDaysRequestFormat, routeId));
        }

        public static string GetRouteCurrentSeasonUri(int routeId)
        {
            return GetRequestUri(string.Format(RouteSeasonRequestFormat, routeId));
        }

        public static string GetRouteSeasonsListUri(int routeId)
        {
            return GetRequestUri(string.Format(RouteSeasonsRequestFormat, routeId));
        }

        public static string GetDirectionsUri(DaysOfOperation day, int routeId)
        {
            return GetRequestUri(string.Format(DirectionRequestFormat, day.ToDayId(), routeId));
        }

        public static string GetStopsUri(DaysOfOperation day, Direction direction, int routeId, Season season, VehicleType vehicleType)
        {
            return GetRequestUri(string.Format(StopsRequestFormat, day.ToDayId(), (byte)direction, routeId, season.ToSeasonId(), (int)vehicleType));
        }

        public static string GetScheduleUri(DaysOfOperation day, Direction direction, int routeId, Season season, int stopId, VehicleType vehicleType)
        {
            return GetRequestUri(string.Format(ScheduleRequestFormat, day.ToDayId(), (byte)direction, routeId, season.ToSeasonId(), stopId, (int)vehicleType));
        }

        public static string GetRouteInfoUri(int routeId)
        {
            return GetRequestUri(string.Format(RouteInfoRequestFormat, routeId));
        }

        public static string GetStopInfoUri(int stopId)
        {
            return GetRequestUri(string.Format(StopInfoRequestFormat, stopId));
        }

        public static string GetValidityTimeUri(DaysOfOperation day, Direction direction, int routeId, Season season, VehicleType vehicleType)
        {
            return GetRequestUri(string.Format(ValidityTimeRequestFormat, day.ToDayId(), (byte)direction, routeId, season.ToSeasonId(), (int)vehicleType));
        }
    }
}
