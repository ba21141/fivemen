﻿using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using FT.DAL.Orm;

/// <summary>
///Dict 的摘要说明
/// </summary>
[SimpleTable("table_dicts")]
[Alias("字典表")]
public class Dict
{
    public Dict()
    {
        //
        //TODO: 在此处添加构造函数逻辑
        //
    }
    [SimplePK]
    [OracleSeqAttribute(SeqName = "seq_dict")]
    public int Id;

    public int 编号
    {
        get { return Id; }
        set { Id = value; }
    }

    [SimpleColumn(Column = "c_typename")]
    [Alias("类别名")]
    public String TypeName;

    public String 类别名
    {
        get { return TypeName; }
        set { TypeName = value; }
    }

    [SimpleColumn(Column = "c_dict_text")]
    [Alias("文本值")]
    public String DictText;

    public String 文本值
    {
        get { return DictText; }
        set { DictText = value; }
    }

    [SimpleColumn(Column = "c_dict_value")]
    [Alias("代码值")]
    public String DictValue;

    public String 代码值
    {
        get { return DictValue; }
        set { DictValue = value; }
    }

    [SimpleColumn(Column = "c_des1")]
    [Alias("说明1")]
    public String Des1;

    public String 说明1
    {
        get { return Des1; }
        set { Des1 = value; }
    }
    [SimpleColumn(Column = "c_des2")]
    [Alias("说明2")]
    public String Des2;

    public String 说明2
    {
        get { return Des2; }
        set { Des2 = value; }
    }
    [SimpleColumn(Column = "c_des3")]
    [Alias("说明3")]
    public String Des3;

    public String 说明3
    {
        get { return Des3; }
        set { Des3 = value; }
    }

    [SimpleColumn(Column = "c_state")]
    [Alias("状态")]
    public String State;

    public String 状态
    {
        get { return State; }
        set { State = value; }
    }
}
