﻿using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using FT.Commons.Tools;
using FT.DAL.Orm;
using System.Collections;

public partial class FpSystem_FpHelper_FpViewCheckinList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["site_id"] == null && Session["bustype"] == null) {
            return;
        }

        string site_id = Session["site_id"].ToString();
        string bustype = Session["bustype"].ToString();
        string lStrToday = DateTime.Now.ToString("yyyy-MM-dd");
        string condition = string.Format(" where SITE_ID={0} and BUSTYPE='{1}' and to_char(CHECKIN_DATE,'YYYY-MM-DD') = '{2}' "
            , site_id
            , bustype
            , lStrToday
        );
        ArrayList listLogs = SimpleOrmOperator.QueryConditionList<FpCheckinLog>(condition);
        rpLogs.DataSource = listLogs;
        rpLogs.DataBind();
    }
}
