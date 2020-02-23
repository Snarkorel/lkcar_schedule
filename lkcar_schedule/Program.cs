using System;
using Snarkorel.lkcar_schedule.enums;
using Snarkorel.lkcar_schedule.json;

namespace Snarkorel.lkcar_schedule
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting...");

            var routeId = 160;
            var seasonId = Season.SUMMER;
            var daysId = DaysOfOperation.Weekdays;
            var directionId = Direction.Forward;
            var vehicleId = VehicleType.Bus;
            var stopId = 10905;

            var infoGetter = new ScheduleInfoGetter();

            Console.WriteLine("Common days of operation:");
            var days = infoGetter.GetCommonDaysList();
            foreach (DaysDto day in days)
            {
                Console.WriteLine("Day: {0} - {1}", day.id, day.text);
            }
            Console.WriteLine("============");

            Console.WriteLine("Common seasons:");
            var seasons = infoGetter.GetCommonSeasonsList();
            foreach (SeasonDto season in seasons)
            {
                Console.WriteLine("Season: {0} - {1}", season.id, season.text);
            }
            Console.WriteLine("============");

            Console.WriteLine("Common vehicle types:");
            var vehicleTypes = infoGetter.GetCommonVehicleTypesList();
            foreach (VehicleTypeDto vehicleType in vehicleTypes)
            {
                Console.WriteLine("vehicleType: {0} - {1}", vehicleType.id, vehicleType.name);
            }
            Console.WriteLine("============");

            Console.WriteLine("Routes by vehicle type {0}:", vehicleId);
            var routes = infoGetter.GetRoutesList(vehicleId);
            foreach (RouteDto route in routes)
            {
                Console.WriteLine("route: {0} - {1}", route.id, route.routeName);
            }
            Console.WriteLine("============");

            Console.WriteLine("Days of operation for route id={0}:", routeId);
            var daysForRoute = infoGetter.GetRouteDaysList(routeId);
            Console.WriteLine("Days: {0} - {1}", daysForRoute.id, daysForRoute.text);
            Console.WriteLine("============");

            Console.WriteLine("Seasons for route id={0}:", routeId);
            var seasonsForRoute = infoGetter.GetRouteSeasonsList(routeId);
            Console.WriteLine("Season: {0} - {1}", seasonsForRoute.id, seasonsForRoute.text);
            Console.WriteLine("============");

            Console.WriteLine("Directions for route id={0}, daysOfOperation={1}:", routeId, daysId);
            var directions = infoGetter.GetDirections(daysId, routeId);
            foreach (DirectionDto direction in directions)
            {
                Console.WriteLine("direction: {0} - {1}", direction.id, direction.direction);
            }
            Console.WriteLine("============");

            Console.WriteLine("Stops list for route id={0}, daysOfOperation={1}, direction={2}, season={3}, vehicleType={4}:", routeId, daysId, directionId, seasonId, vehicleId);
            var stops = infoGetter.GetStops(daysId, directionId, routeId, seasonId, vehicleId);
            foreach (StopDto stop in stops)
            {
                Console.WriteLine("stop: {0} - {1}", stop.id, stop.stopName);
            }
            Console.WriteLine("============");

            var schedule = infoGetter.GetSchedule(daysId, directionId, routeId, seasonId, stopId, vehicleId); //FAILED
            //TODO
            Console.WriteLine("============");

            var routeInfo = infoGetter.GetRouteInfo(routeId);
            //TODO
            Console.WriteLine("============");

            var stopInfo = infoGetter.GetStopInfo(stopId);
            //TODO
            Console.WriteLine("============");

            var validityTime = infoGetter.GetValidityTime(daysId, directionId, routeId, seasonId, vehicleId);
            //TODO
            Console.WriteLine("============");
            
            Console.WriteLine("Finished!");
        }
    }
}
