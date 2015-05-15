﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WcTusService.TuesdayModel
{
    /// <summary>
    /// 奖品模板业务实体类
    /// </summary>
    public class RewardTemplate
    {
        /// <summary>
        /// 奖品模板
        /// </summary>
        private tb_rewardTemplate rewardTmp;

        public tb_rewardTemplate RewardTmp
        {
            get { return rewardTmp; }
            set { rewardTmp = value; }
        }
        /// <summary>
        /// 奖品模板关联列表
        /// </summary>
        private List<tb_reward_Template_imp> rewardTemplateImp;

        public List<tb_reward_Template_imp> RewardTemplateImp
        {
            get { return rewardTemplateImp; }
            set { rewardTemplateImp = value; }
        }
    }
}