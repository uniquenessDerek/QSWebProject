﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QS.Core.Module.CommentAggregate;
using QS.Core.Module.SharedAggregate;

namespace QS.Core.IRepository
{
    public interface IArticleCommentRepository : IRepository<ArticleComment>
    {
    }
}
