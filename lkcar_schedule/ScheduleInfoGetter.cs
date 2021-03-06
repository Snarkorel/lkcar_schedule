﻿using Newtonsoft.Json;
using Snarkorel.lkcar_schedule.enums;
using Snarkorel.lkcar_schedule.json;
using System;
using System.Collections.Generic;
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

        public List<DaysDto> GetCommonDaysList()
        {
            var req = RequestUriFactory.GetCommonDaysListUri();
            var resp = HttpGetRequest(req);
            try
            {
                return (List<DaysDto>)JsonConvert.DeserializeObject(resp.Result, typeof(List<DaysDto>));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<SeasonDto> GetCommonSeasonsList()
        {
            var req = RequestUriFactory.GetCommonSeasonsListUri();
            var resp = HttpGetRequest(req);
            try
            {
                return (List<SeasonDto>)JsonConvert.DeserializeObject(resp.Result, typeof(List<SeasonDto>));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<VehicleTypeDto> GetCommonVehicleTypesList()
        {
            var req = RequestUriFactory.GetCommonVehicleTypesListUri();
            var resp = HttpGetRequest(req);
            try
            {
                return (List<VehicleTypeDto>)JsonConvert.DeserializeObject(resp.Result, typeof(List<VehicleTypeDto>));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<RouteDto> GetRoutesList(VehicleType vehicleType)
        {
            var req = RequestUriFactory.GetRoutesListUri(vehicleType);
            var resp = HttpGetRequest(req);
            try
            {
                return (List<RouteDto>)JsonConvert.DeserializeObject(resp.Result, typeof(List<RouteDto>));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<DaysDto> GetRouteDaysList(int routeId)
        {
            var req = RequestUriFactory.GetRouteDaysListUri(routeId);
            var resp = HttpGetRequest(req);
            try
            {
                return (List<DaysDto>)JsonConvert.DeserializeObject(resp.Result, typeof(List<DaysDto>));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public DaysDto GetRouteCurrentDay(int routeId)
        {
            var req = RequestUriFactory.GetRouteCurrentDayUri(routeId);
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

        public List<SeasonDto> GetRouteSeasonsList(int routeId)
        {
            var req = RequestUriFactory.GetRouteSeasonsListUri(routeId);
            var resp = HttpGetRequest(req);
            try
            {
                return (List<SeasonDto>)JsonConvert.DeserializeObject(resp.Result, typeof(List<SeasonDto>));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public SeasonDto GetRouteCurrentSeason(int routeId)
        {
            var req = RequestUriFactory.GetRouteCurrentSeasonUri(routeId);
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

        public List<DirectionDto> GetDirections(DaysOfOperation day, int routeId)
        {
            var req = RequestUriFactory.GetDirectionsUri(day, routeId);
            var resp = HttpGetRequest(req);
            try
            {
                return (List<DirectionDto>)JsonConvert.DeserializeObject(resp.Result, typeof(List<DirectionDto>));
            }
            catch (Exception)
            {
                return null;
            }
        }

        public List<StopDto> GetStops(DaysOfOperation day, Direction direction, int routeId, Season season, VehicleType vehicleType)
        {
            var req = RequestUriFactory.GetStopsUri(day, direction, routeId, season, vehicleType);
            var resp = HttpGetRequest(req);
            try
            {
                return (List<StopDto>)JsonConvert.DeserializeObject(resp.Result, typeof(List<StopDto>));
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
