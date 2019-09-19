namespace Snarkorel.lkcar_schedule.json
{
    public class Stop //req: http://lkcar.transport.mos.ru/ExternalService/api/schedule/stop?day=WEEKDAYS&directionId=0&routeId=255&season=SUMMER&vehicleTypeId=700
    {
        public int id { get; set; } //stopId
        public string stopName { get; set; }
    }
}
