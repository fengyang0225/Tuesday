
//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------


namespace WcTusService.TuesdayModel
{

using System;
    using System.Collections.Generic;
    
public partial class tb_task
{

    public int pk_task_id { get; set; }

    public string nvr_taskName { get; set; }

    public System.DateTime dtm_createTime { get; set; }

    public System.DateTime dtm_actionTime { get; set; }

    public System.DateTime dtm_endTime { get; set; }

    public bool bit_isDelete { get; set; }

    public bool bit_status { get; set; }

    public bool bit_inherit { get; set; }

    public int fk_share_id { get; set; }

}

}
