using Newtonsoft.Json;
using Snarkorel.lkcar_schedule.enums;
using Snarkorel.lkcar_schedule.json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Snarkorel.lkcar_schedule
{
    public class ScheduleInfoGetter
    {
        private HttpClient _client;

        public ScheduleInfoGetter()
        {
            _client = new HttpClient();
        }

        private async Task<string> HttpGetRequest(string uri)
        {
            var response = await _client.GetAsync(uri);
            response.EnsureSuccessStatusCode();
            var responseBody = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            if (responseBody.Length == 0)
                throw new Exception("Empty HTTP response!");
            return responseBody;
        }

        public DaysDto GetCommonDaysList()
        {
            var req = RequestUriFactory.GetCommonDaysListUri();
            var resp = HttpGetRequest(req);
            try
            {
                return (DaysDto)JsonConvert.DeserializeObject(resp.Result, typeof(DaysDto));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public SeasonDto GetCommonSeasonsList()
        {
            var req = RequestUriFactory.GetCommonSeasonsListUri();
            var resp = HttpGetRequest(req);
            try
            {
                return (SeasonDto)JsonConvert.DeserializeObject(resp.Result, typeof(SeasonDto));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public VehicleTypeDto GetCommonVehicleTypesList()
        {
            var req = RequestUriFactory.GetCommonVehicleTypesListUri();
            var resp = HttpGetRequest(req);
            try
            {
                return (VehicleTypeDto)JsonConvert.DeserializeObject(resp.Result, typeof(VehicleTypeDto));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public RouteDto GetRoutesList(VehicleType vehicleType)
        {
            var req = RequestUriFactory.GetRoutesListUri(vehicleType);
            var resp = HttpGetRequest(req);
            try
            {
                return (RouteDto)JsonConvert.DeserializeObject(resp.Result, typeof(RouteDto));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DaysDto GetRouteDaysList(int routeId)
        {
            var req = RequestUriFactory.GetRouteDaysListUri(routeId);
            var resp = HttpGetRequest(req);
            try
            {
                return (DaysDto)JsonConvert.DeserializeObject(resp.Result, typeof(DaysDto));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public SeasonDto GetRouteSeasonsList(int routeId)
        {
            var req = RequestUriFactory.GetRouteSeasonsListUri(routeId);
            var resp = HttpGetRequest(req);
            try
            {
                return (SeasonDto)JsonConvert.DeserializeObject(resp.Result, typeof(SeasonDto));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DirectionDto GetDirections(DaysOfOperation day, int routeId)
        {
            var req = RequestUriFactory.GetDirectionsUri(day, routeId);
            var resp = HttpGetRequest(req);
            try
            {
                return (DirectionDto)JsonConvert.DeserializeObject(resp.Result, typeof(DirectionDto));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public StopDto GetStops(DaysOfOperation day, Direction direction, int routeId, Season season, VehicleType vehicleType)
        {
            var req = RequestUriFactory.GetStopsUri(day, direction, routeId, season, vehicleType);
            var resp = HttpGetRequest(req);
            try
            {
                return (StopDto)JsonConvert.DeserializeObject(resp.Result, typeof(StopDto));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public ScheduleDto GetSchedule(DaysOfOperation day, Direction direction, int routeId, Season season, int stopId, VehicleType vehicleType)
        {
            var req = RequestUriFactory.GetScheduleUri(day, direction, routeId, season, stopId, vehicleType);
            var resp = HttpGetRequest(req);
            try
            {
                return (ScheduleDto)JsonConvert.DeserializeObject(resp.Result, typeof(ScheduleDto));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public RouteDto GetRouteInfo(int routeId)
        {
            var req = RequestUriFactory.GetRouteInfoUri(routeId);
            var resp = HttpGetRequest(req);
            try
            {
                return (RouteDto)JsonConvert.DeserializeObject(resp.Result, typeof(RouteDto));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public StopDto GetStopInfo(int stopId)
        {
            var req = RequestUriFactory.GetStopInfoUri(stopId);
            var resp = HttpGetRequest(req);
            try
            {
                return (StopDto)JsonConvert.DeserializeObject(resp.Result, typeof(StopDto));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public ValidityTimeDto GetValidityTime(DaysOfOperation day, Direction direction, int routeId, Season season, VehicleType vehicleType)
        {
            var req = RequestUriFactory.GetValidityTimeUri(day, direction, routeId, season, vehicleType);
            var resp = HttpGetRequest(req);
            try
            {
                return (ValidityTimeDto)JsonConvert.DeserializeObject(resp.Result, typeof(ValidityTimeDto));
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
