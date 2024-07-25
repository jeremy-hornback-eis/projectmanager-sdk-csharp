/***
 * ProjectManager API for C#
 *
 * (c) 2023-2024 ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  2023-2024 ProjectManager.com, Inc.
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// Export Settings for Risk Export
    /// </summary>
    public class RiskExportSettingsDto : ApiModel
    {

        /// <summary>
        /// the name used by the export
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Format to export to, currently csv and excel are supported
        ///
        ///  Valid options are:
        ///  * csv
        ///  * excel
        /// </summary>
        public string Format { get; set; }

        /// <summary>
        /// The list of column names to export
        /// </summary>
        public string[] Columns { get; set; }

        /// <summary>
        /// Which column should be used to order the data
        ///
        ///  Valid options are:
        ///  * name
        ///  * createDate
        ///  * assignees
        ///  * dueDate
        ///  * impact
        ///  * level
        ///  * likelihood
        ///  * openClosed
        ///  * priority
        ///  * response
        ///  * tags
        ///  * description
        ///  * resolution
        /// </summary>
        public string OrderBy { get; set; }

        /// <summary>
        /// Specifies the direction of the order. Valid values are &quot;asc&quot; and &quot;desc&quot;
        ///
        ///  Valid options are:
        ///  * asc
        ///  * desc
        /// </summary>
        public string OrderDirection { get; set; }
    }
}
