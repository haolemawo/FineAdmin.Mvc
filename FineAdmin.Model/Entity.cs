﻿using System;

namespace FineAdmin.Model
{
    public class Entity
    {
        /// <summary>
        /// 主键
        /// </summary>
        [DapperExtensions.Key(true)]
        public int Id { get; set; }
        /// <summary>
        /// 排序码
        /// </summary>
        public virtual int SortCode { get; set; }
        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// 有效标识 0：有效 1：无效
        /// </summary>
        public bool EnabledMark { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 创建用户主键
        /// </summary>
        public int CreateUserId { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 修改用户主键
        /// </summary>
        public int UpdateUserId { get; set; }
    }
}