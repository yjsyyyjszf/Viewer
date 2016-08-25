
#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion



using Macro.ImageViewer.Common.WorkItem;
using Macro.ImageViewer.StudyManagement.Core.Storage;

namespace Macro.ImageViewer.StudyManagement.Core
{
    public static class WorkItemDataHelper
    {
        public static WorkItemData FromWorkItem(WorkItem item)
        {
            return new WorkItemData
                       {
                           Type = item.Type,
                           Status = item.Status,
                           Priority = item.Priority,
                           DeleteTime = item.DeleteTime,
                           ExpirationTime = item.ExpirationTime,
                           ScheduledTime = item.ScheduledTime,
                           RequestedTime = item.RequestedTime,
                           FailureCount = item.FailureCount,
                           Identifier = item.Oid,
                           ProcessTime = item.ProcessTime,
                           StudyInstanceUid = item.StudyInstanceUid,
                           Request = item.Request,
                           Progress = item.Progress
                       };
        }
    }
}