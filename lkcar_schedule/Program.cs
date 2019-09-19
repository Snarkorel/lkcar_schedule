using System;
using Snarkorel.lkcar_schedule.enums;

namespace Snarkorel.lkcar_schedule
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("starting...");

            var routeId = 160;
            var seasonId = Season.SUMMER;
            var daysId = DaysOfOperation.Weekdays;
            var directionId = Direction.Forward;
            var vehicleId = VehicleType.Bus;
            var stopId = 10905;

            var infoGetter = new ScheduleInfoGetter();

            var days = infoGetter.GetCommonDaysList();
            //Console.WriteLine("days: {0} {1}", days.id, days.text); //TODO

            var seasons = infoGetter.GetCommonSeasonsList();
            //Console.WriteLine("days: {0} {1}", seasons.id, seasons.text); //TODO

            var vehicleTypes = infoGetter.GetCommonVehicleTypesList();
            //Console.WriteLine("vehicleTypes: {0} {1}", vehicleTypes.id, vehicleTypes.name); //TODO

            var routes = infoGetter.GetRoutesList(vehicleId);
            //TODO

            var daysForRoute = infoGetter.GetRouteDaysList(routeId);
            //TODO

            var seasonsForRoute = infoGetter.GetRouteSeasonsList(routeId);
            //TODO

            var directions = infoGetter.GetDirections(daysId, routeId);
            //TODO

            var stops = infoGetter.GetStops(daysId, directionId, routeId, seasonId, vehicleId);
            //TODO

            var schedule = infoGetter.GetSchedule(daysId, directionId, routeId, seasonId, stopId, vehicleId); //FAILED
            //TODO

            var routeInfo = infoGetter.GetRouteInfo(routeId);
            //TODO

            var stopInfo = infoGetter.GetStopInfo(stopId);
            //TODO

            var validityTime = infoGetter.GetValidityTime(daysId, directionId, routeId, seasonId, vehicleId);
            //TODO


            Console.WriteLine("finished");
        }
    }
}
