﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SnowPlatformMonitor.Core.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class SqlScripts {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal SqlScripts() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("SnowPlatformMonitor.Core.Resources.SqlScripts", typeof(SqlScripts).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT TOP 5 * FROM SnowLicenseManager.dbo.tblErrorLog
        ///ORDER BY logDate DESC.
        /// </summary>
        public static string DataUpdateJobErrorLog {
            get {
                return ResourceManager.GetString("DataUpdateJobErrorLog", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT TOP 5 * FROM msdb.dbo.sysjobhistory where sql_severity &gt; 0 order by run_date desc, run_time desc.
        /// </summary>
        public static string DataUpdateJobErrorSevere {
            get {
                return ResourceManager.GetString("DataUpdateJobErrorSevere", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT * FROM SnowLicenseManager.inv.tblJobParallelStep
        ///WHERE Status = -1.
        /// </summary>
        public static string DataUpdateJobParallel {
            get {
                return ResourceManager.GetString("DataUpdateJobParallel", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SELECT
        ///    job.name, 
        ///    job.job_id, 
        ///    job.originating_server, 
        ///    activity.run_requested_date, 
        ///    DATEDIFF( SECOND, activity.run_requested_date, GETDATE() ) as Elapsed
        ///FROM 
        ///    msdb.dbo.sysjobs_view job
        ///JOIN
        ///    msdb.dbo.sysjobactivity activity
        ///ON 
        ///    job.job_id = activity.job_id
        ///JOIN
        ///    msdb.dbo.syssessions sess
        ///ON
        ///    sess.session_id = activity.session_id
        ///JOIN
        ///(
        ///    SELECT
        ///        MAX( agent_start_date ) AS max_agent_start_date
        ///    FROM
        ///        msdb.dbo.syssessions
        ///) sess_ [rest of string was truncated]&quot;;.
        /// </summary>
        public static string DataUpdateJobStatus {
            get {
                return ResourceManager.GetString("DataUpdateJobStatus", resourceCulture);
            }
        }
    }
}
