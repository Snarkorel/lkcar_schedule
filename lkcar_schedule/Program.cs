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
            foreach (DaysDto day in daysForRoute)
            {
                Console.WriteLine("day: {0} - {1}", day.id, day.text);
            }
            Console.WriteLine("============");

            Console.WriteLine("Current day of operation for route id={0}:", routeId);
            var currentDayForRoute = infoGetter.GetRouteCurrentDay(routeId);
            Console.WriteLine("day: {0} - {1}", currentDayForRoute.id, currentDayForRoute.text);
            Console.WriteLine("============");

            Console.WriteLine("Seasons for route id={0}:", routeId);
            var seasonsForRoute = infoGetter.GetRouteSeasonsList(routeId);
            foreach (SeasonDto season in seasonsForRoute)
            {
                Console.WriteLine("season: {0} - {1}", season.id, season.text);
            }
            Console.WriteLine("============");

            Console.WriteLine("Current season for route id={0}:", routeId);
            var currentSeasonForRoute = infoGetter.GetRouteCurrentSeason(routeId);
            Console.WriteLine("season: {0} - {1}", currentSeasonForRoute.id, currentSeasonForRoute.text);
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

            Console.WriteLine("Route info for route id={0}:", routeId);
            var routeInfo = infoGetter.GetRouteInfo(routeId);
            Console.WriteLine("routes: {0} - {1}", routeInfo.id, routeInfo.routeName);
            Console.WriteLine("============");

            Console.WriteLine("Stop info for stop id={0}:", stopId);
            var stopInfo = infoGetter.GetStopInfo(stopId);
            Console.WriteLine("stop: {0} - {1}", stopInfo.id, stopInfo.stopName);
            Console.WriteLine("============");

            Console.WriteLine("Validity time for route={0} daysId={1} directionId={2} seasonId={3}, vehicleId={4}:", routeId, daysId, directionId, seasonId, vehicleId);
            var validityTime = infoGetter.GetValidityTime(daysId, directionId, routeId, seasonId, vehicleId); //there is an unknown format. It's not UnixTime nor .NET ticks
            //var fromTime = (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(validityTime.fromTime); //converting UnixTime to DateTime
            //var toTime = (new DateTime(1970, 1, 1, 0, 0, 0, 0)).AddSeconds(validityTime.toTime);
            //Console.WriteLine("Valid from {0} till {1}", fromTime, toTime);
            Console.WriteLine("============");
            
            Console.WriteLine("Finished!");
        }
    }
}
