﻿using DapperExtensions;
using System;
using System.ComponentModel.DataAnnotations;

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
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        [Display(Name = "创建时间")]
        public DateTime CreateTime { get; set; }
        /// <summary>
        /// 创建用户主键
        /// </summary>
        public int CreateUserId { get; set; }
        /// <summary>
        /// 修改时间
        /// </summary>
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd HH:mm:ss}")]
        [Display(Name = "修改时间")]
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// 修改用户主键
        /// </summary>
        public int UpdateUserId { get; set; }
        /// <summary>
        /// 查询时间范围
        /// </summary>
        [Computed]
        public string StartEndDate { get; set; }
        /// <summary>
        /// 用来接收查询启用禁用的值，EnabledMark Bool类型映射不到
        /// </summary>
        [Computed]
        public int? EnabledMarkSelect { get; set; }
    }
}
