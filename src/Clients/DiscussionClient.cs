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



using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using ProjectManager.SDK.Interfaces;
using ProjectManager.SDK.Models;


namespace ProjectManager.SDK.Clients
{
    /// <summary>
    /// API methods related to Discussion
    /// </summary>
    public class DiscussionClient : IDiscussionClient
    {
        private readonly ProjectManagerClient _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public DiscussionClient(ProjectManagerClient client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieve all comments written about a task
        /// </summary>
        /// <param name="taskId">The unique ID number of the task to retrieve comments</param>
        public async Task<AstroResult<DiscussionCommentDto[]>> RetrieveTaskComments(Guid taskId)
        {
            var url = $"/api/data/tasks/{taskId}/comments";
            return await _client.Request<DiscussionCommentDto[]>(HttpMethod.Get, url, null);
        }

        /// <summary>
        /// Adds a Markdown-formatted comment to a task.
        ///
        /// Tasks can have discussions attached to them.  These discussions can include text with simple
        /// formatting.  Discussion comments are formatted using [Markdown](https://www.markdownguide.org/)
        /// and users should be aware that HTML embedding is not permitted due to the risk of cross-site
        /// attacks and other embedding challenges.
        /// </summary>
        /// <param name="taskId">The unique ID number of the task being commented upon</param>
        /// <param name="body">The Markdown-formatted text of the comment</param>
        public async Task<AstroResult<DiscussionCommentCreateResponseDto>> CreateTaskComments(Guid taskId, DiscussionCommentCreateDto body)
        {
            var url = $"/api/data/tasks/{taskId}/comments";
            return await _client.RequestWithBody<DiscussionCommentCreateResponseDto>(HttpMethod.Post, url, null, body);
        }
    }
}
