namespace Snarkorel.lkcar_schedule.json
{
    public class Direction //req: http://lkcar.transport.mos.ru/ExternalService/api/schedule/direction?day=WEEKDAYS&routeId=3
    {
        public int id { get; set; } //route id
        public string direction { get; set; }
    }
}
