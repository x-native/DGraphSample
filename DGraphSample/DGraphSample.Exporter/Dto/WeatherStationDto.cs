﻿// Copyright (c) Philipp Wagner. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace DGraphSample.Exporter.Dto
{
    public class WeatherStationDto
    {
        /// <summary>
        /// The NodeId
        /// </summary>
        public string NodeId { get; set; }

        /// <summary>
        /// 16 character station long name
        /// </summary>
        public string Station { get; set; }

        /// <summary>
        /// 4-character international id
        /// </summary>
        public string ICAO { get; set; }

        /// <summary>
        /// 3-character(FAA) id
        /// </summary>
        public string IATA { get; set; }

        /// <summary>
        /// 5-digit international synoptic number
        /// </summary>
        public string SYNOP { get; set; }

        /// <summary>
        /// Latitude(degrees minutes)
        /// </summary>
        public string Latitude { get; set; }

        /// <summary>
        /// Longitude(degree minutes)
        /// </summary>
        public string Longitude { get; set; }

        /// <summary>
        /// Station elevation(meters)
        /// </summary>
        public float? Elevation { get; set; }
    }
}
