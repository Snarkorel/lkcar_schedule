namespace Snarkorel.lkcar_schedule.json
{
    public class Season //req: http://lkcar.transport.mos.ru/ExternalService/api/schedule/seasons
    {
        public string id { get; set; } //season id
        public string text { get; set; }
    }
    //http://lkcar.transport.mos.ru/ExternalService/api/schedule/season?routeId=305
}
