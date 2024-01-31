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
    /// A ProjectManager is a person who manages a Project.
    /// </summary>
    public class ProjectManagerDto : ApiModel
    {

        /// <summary>
        /// The unique identifier of this ProjectManager
        /// </summary>
        public Guid? Id { get; set; }

        /// <summary>
        /// The name of this ProjectManager
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Manager initials
        /// </summary>
        public string Initials { get; set; }

        /// <summary>
        /// Avatar&#39;s url
        /// </summary>
        public string AvatarUrl { get; set; }
    }
}
