﻿// ReSharper disable InconsistentNaming
namespace DreamFactory.Model.File
{
    using global::System;
    using global::System.Collections.Generic;

    /// <summary>
    /// A storage container information.
    /// </summary>
    public class ContainerInfo
    {
        /// <summary>
        /// Identifier/Name for the container.
        /// </summary>
        public string name { get; set; }

        /// <summary>
        /// Same as name for the container, for consistency.
        /// </summary>
        public string path { get; set; }

        /// <summary>
        /// Date and time of last modification.
        /// </summary>
        public DateTime? last_modified { get; set; }

        /// <summary>
        /// List of allowed HTTP verbs.
        /// </summary>
        public List<string> access { get; set; } 
    }
}
