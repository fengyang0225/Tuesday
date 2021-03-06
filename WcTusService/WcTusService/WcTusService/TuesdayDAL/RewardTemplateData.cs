﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WcTusService.TuesdayModel;

namespace WcTusService.Data
{
    /// <summary>
    /// 奖品模板数据访问类
    /// </summary>
    public class RewardTemplateData
    {
        //数据库模型
        ShareWeiEntities db = new ShareWeiEntities();
        /// <summary>
        /// 添加奖品模板信息
        /// </summary>
        public int AddRewardTmp(tb_rewardTemplate rdt)
        {
            if (rdt != null)
            {
                db.tb_rewardTemplate.Add(rdt);
                int returnNum = db.SaveChanges();
                return returnNum;
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// 更新奖品模板信息
        /// </summary>
        public int EditRewardTmp(tb_rewardTemplate tr)
        {
            if (tr != null)
            {
                db.Entry(tr).State = EntityState.Modified;
                return db.SaveChanges();
            }
            else
            {
                return 0;
            }
        }
        /// <summary>
        /// 根据奖品模板主键ID查询模板信息
        /// </summary>
        /// <param name="id">主键ID</param>
        /// <returns></returns>
        public tb_rewardTemplate GetRewardTmpById(int id)
        {
            var rt = from r in db.tb_rewardTemplate
                     where r.pk_rewardTemplate_id == id
                     select r;
            if (rt.ToList().Count > 0)
                return rt.FirstOrDefault();
            else
                return null;
        }
        /// <summary>
        /// 查询奖品模板信息集合
        /// </summary>
        /// <returns></returns>
        public List<tb_rewardTemplate> GetRewardTmpList()
        {
            var rt = from r in db.tb_rewardTemplate
                     where r.bit_isDelete==false
                     select r;
            return rt.ToList();
        }
        /// <summary>
        /// 根据奖励模板ID获取糖币信息
        /// </summary>
        /// <param name="id">奖励模板ID</param>
        /// <returns>糖币信息</returns>
        public tb_reward GetTangbiByTmpId(int id)
        {
            tb_rewardTemplate rt =GetRewardTmpById(id);
            if (rt != null)
            {
                List<tb_reward_Template_imp> impList = new RewardTmpImpData().GetRewardImpList(rt.pk_rewardTemplate_id);
                if (impList != null)
                {
                    foreach (var imp in impList)
                    {
                        tb_reward reward = new RewardData().GetRewardByID(imp.fk_reward_id);
                        if (reward.nvr_rewardName.Equals("糖币"))
                        {
                            return reward;
                        }
                    }
                }
                return null;
            }
            else
            {
                return null;
            }
        }
    }
}