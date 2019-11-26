﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FineAdmin.Common;
using FineAdmin.IRepository;
using FineAdmin.IService;
using FineAdmin.Model;

namespace FineAdmin.Service
{
    public class ButtonService : BaseService<ButtonModel>, IButtonService
    {
        public IButtonRepository ButtonRepository { get; set; }
        /// <summary>
        /// 根据角色菜单获得按钮列表
        /// </summary>
        /// <param name="roleId"></param>
        /// <param name="moduleId"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public IEnumerable<ButtonModel> GetButtonListByRoleIdModuleId(int roleId, int moduleId, PositionEnum position)
        {
            return ButtonRepository.GetButtonListByRoleIdModuleId(roleId, moduleId, position);
        }

        public dynamic GetListByFilter(ButtonModel filter, PageInfo pageInfo)
        {
            string _where = " where 1=1";
            if (!string.IsNullOrEmpty(filter.EnCode))
            {
                _where += " and EnCode=@EnCode";
            }
            if (!string.IsNullOrEmpty(filter.FullName))
            {
                _where += " and FullName=@FullName";
            }
            return GetListByFilter(filter, pageInfo, _where);
        }

    }
}
