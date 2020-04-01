using Newtonsoft.Json;
using System.Collections.Generic;

namespace Snarkorel.lkcar_schedule.json
{
    public class ScheduleDto
    {
        //TODO: rewrite bydlocode

        [JsonProperty("0")]
        public List<int> _0 { get; set; }
        [JsonProperty("1")]
        public List<int> _1 { get; set; }
        [JsonProperty("2")]
        public List<int> _2 { get; set; }
        [JsonProperty("3")]
        public List<int> _3 { get; set; }
        [JsonProperty("4")]
        public List<int> _4 { get; set; }
        [JsonProperty("5")]
        public List<int> _5 { get; set; }
        [JsonProperty("6")]
        public List<int> _6 { get; set; }
        [JsonProperty("7")]
        public List<int> _7 { get; set; }
        [JsonProperty("8")]
        public List<int> _8 { get; set; }
        [JsonProperty("9")]
        public List<int> _9 { get; set; }
        [JsonProperty("10")]
        public List<int> _10 { get; set; }
        [JsonProperty("11")]
        public List<int> _11 { get; set; }
        [JsonProperty("12")]
        public List<int> _12 { get; set; }
        [JsonProperty("13")]
        public List<int> _13 { get; set; }
        [JsonProperty("14")]
        public List<int> _14 { get; set; }
        [JsonProperty("15")]
        public List<int> _15 { get; set; }
        [JsonProperty("16")]
        public List<int> _16 { get; set; }
        [JsonProperty("17")]
        public List<int> _17 { get; set; }
        [JsonProperty("18")]
        public List<int> _18 { get; set; }
        [JsonProperty("19")]
        public List<int> _19 { get; set; }
        [JsonProperty("20")]
        public List<int> _20 { get; set; }
        [JsonProperty("21")]
        public List<int> _21 { get; set; }
        [JsonProperty("22")]
        public List<int> _22 { get; set; }
        [JsonProperty("23")]
        public List<int> _23 { get; set; }

        public Dictionary<int, List<int>> GetSchedule()
        {
            return new Dictionary<int, List<int>>()
            {
                { 0, _0 },
                { 1, _1 },
                { 2, _2 },
                { 3, _3 },
                { 4, _4 },
                { 5, _5 },
                { 6, _6 },
                { 7, _7 },
                { 8, _8 },
                { 9, _9 },
                { 10, _10 },
                { 11, _11 },
                { 12, _12 },
                { 13, _13 },
                { 14, _14 },
                { 15, _15 },
                { 16, _16 },
                { 17, _17 },
                { 18, _18 },
                { 19, _19 },
                { 20, _20 },
                { 21, _21 },
                { 22, _22 },
                { 23, _23 },
            };
        }
    }
}
