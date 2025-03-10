/***
 * ProjectManager API for C#
 *
 * (c) ProjectManager.com, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     ProjectManager.com <support@projectmanager.com>
 * @copyright  ProjectManager.com, Inc.
 * @link       https://github.com/projectmgr/projectmanager-sdk-csharp
 */



#pragma warning disable CS8618

using System;

namespace ProjectManager.SDK.Models
{

    /// <summary>
    /// Dto To Describe a ProjectMember Role
    /// </summary>
    public class ProjectMemberRoleDto : ApiModel
    {

        /// <summary>
        /// Role to apply
        ///
        /// For a list of values, see `ProjectPermissionValues`.
        /// </summary>
        public string Role { get; set; }
    }
}
