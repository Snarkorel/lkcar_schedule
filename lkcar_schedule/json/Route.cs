namespace Snarkorel.lkcar_schedule.json
{
    public class Route //req: http://lkcar.transport.mos.ru/ExternalService/api/schedule/route?vehicleTypeId=700
    {
        public int id { get; set; } //route id
        public string routeName { get; set; }
    }
}
