using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace WebAppProject1.Entity
{
  //  [Table("Pro_initial")]
    public class Pro_initial
    {

        [Key]
        [Display(Name = "رقم التسلسل")]
        public int Id { get; set; }
        [Display(Name = "اسم المشروع")]

        public string Name { get; set; }
        [Display(Name = "الهدف من التقنية")]

        public string Goal { get; set; }
        [Display(Name = "ملخص من التقنية")]

        public string Summary { get; set; }
        [Display(Name = "القيمة المضافة")]

        public string Value { get; set; }

        [Display(Name = "تاريخ الطلب")]
        public DateTime Started_date { get; set; }

        public RequestStatus RequestStatus { get; set; }

        //[Display(Name = "السنة")]

        //public int Pro_YearID { get; set; }

        //[Display(Name = "المخاطر المتوقعة")]

        //public string Risk_details { get; set; }

        //public int Risk_ValueId { get; set; }

        //[Display(Name = "الخطط البديلة")]

        //public string Risk_alternative { get; set; }


        //   [Display(Name = "تاريخ التحديث")]
        //  public DateTime Updated_date { get; set; }

        //  [Display(Name = "العدد")]
        //  public int Quantity { get; set; }

        //  public Nullable<int> Pro_sourcesID { get; set; }

        //  //[ForeignKey("IT_Assets")]
        //  //public Nullable<int> IT_AssetsID { get; set; }

        ////  public virtual IT_Assets IT_Assets { get; set; }
        //  public int SectionsId { get; set; }

        //  public Nullable<int> AT_ID { get; set; }

        //  public Nullable<int> IT_asset_processID { get; set; }
        //  public Nullable<int> Pro_Stakeholders_TypesID { get; set; }

        //  public Nullable<int> Pro_StakeholdersID { get; set; }


        //  public decimal Value1 { get; set; }

        //  public decimal Value2 { get; set; }

        //  public decimal Value3 { get; set; }

        //  public decimal Value4 { get; set; }
        //  public decimal Pro_DurationID { get; set; }

        //  public decimal Difficult2 { get; set; }

        //  public decimal Difficult3 { get; set; }

        //  public decimal Difficult4 { get; set; }

        //  public decimal Difficult5 { get; set; }

        //  public decimal Pro_DependencyID { get; set; }

        //  public decimal Pro_OrganizationID { get; set; }


        //  [Display(Name = "الفائدة والتأثير")]

        //  public Nullable<decimal> Pro_value_percent { get; set; }
        //  [Display(Name = "سهولة التنفيذ")]

        //  public Nullable<decimal> Pro_difficult_percent { get; set; }
        //  [Display(Name = "الأولوية")]

        //  public Nullable<decimal> Pro_periority_percent { get; set; }

        //  //public Nullable<int> Pro_approval_roleID { get; set; }

        //  [Display(Name = "حالة المشروع")]
        //  public Nullable<int> Pro_StatusID { get; set; }
        //  public string By_UserId { get; set; }

        //  public string EmployeesId { get; set; }
        //  public Employees Employees { get; set; }
        //  [Display(Name = "إعداد")]
        //  public String Emp_name { get; set; }

        //  public int DepartmentsId { get; set; }

        //  [Display(Name = "الميزانية التقديرية")]
        //  public double Budgetary { get; set; }

        //  public Nullable<int> Pro_approval_statusID { get; set; }

        //public virtual Pro_Status Pro_Status { get; set; }

        //public virtual Pro_approval_role Pro_approval_role { get; set; }

        //[Display(Name = "الملاحظات")]
        //public string Pro_approval_Note { get; set; }

        //  public int ApprovalListID { get; set; }     


        //  public virtual ApprovalList ApprovalList { get; set; }

        //public virtual Pro_approval_status Pro_approval_status { get; set; }
        //public virtual IT_asset_process IT_asset_process { get; set; }
        //public virtual Departments Departments { get; set; }
        //public virtual IT_Asset_Types IT_Asset_Types { get; set; }

        //public virtual Pro_Year Pro_Year { get; set; }
        //public virtual Risk_Value Risk_Value { get; set; }
        //public virtual Pro_Effect Pro_Effect { get; set; }
        //public virtual Pro_Duration Pro_Duration { get; set; }
        //public virtual Pro_Dependency Pro_Dependency { get; set; }
        //public virtual Pro_Organization Pro_Organization { get; set; }

        //  public virtual AspNetUsers AspNetUsers { get; set; }
        //public virtual Pro_sources Pro_sources { get; set; }
        //public virtual Pro_Stakeholders_Types Pro_Stakeholders_Types { get; set; }

        //public virtual Pro_Stakeholders Pro_Stakeholders { get; set; }

        //public virtual Pro_budget Pro_budget { get; set; }

        //public virtual Sections Sections { get; set; }


        //public string Updated_by_user_id { get; set; }

        //public Nullable<int> ApprDeptID { get; set; }
        //public Nullable<int> ApprCoID { get; set; }
        //public Nullable<int> ApprITSectionID { get; set; }

        //public Nullable<int> ApprITSectionBudget { get; set; }
        //public Nullable<int> ApprITDeptID { get; set; }
        //public Nullable<int> ApprHighMngID { get; set; }

        //public Nullable<int> ApprFinanceID { get; set; }

        //public Nullable<int> ApprRFPId { get; set; }

        //public Nullable<int> TendarRFPId { get; set; }

        //public Nullable<int> ApprActionPlanID { get; set; }
        //public Nullable<int> ApprPaymentID { get; set; }




        //public Nullable<int> Pro_budgetID { get; set; }



        //public Nullable<int> Pro_Tendar_EvalID { get; set; }
        //public virtual Pro_Tendar_Eval Pro_Tendar_Eval { get; set; }

        //public Nullable<int> Pro_CompID { get; set; }
        //public virtual Pro_Comp Pro_Comp { get; set; }

        //[Display(Name = "نسبة الانجاز")]
        //public string Pro_Achievement { get; set; }

        //[Display(Name = "عدد الدفعات")]
        //public int Pro_PaymentCount { get; set; }



        //public virtual Pro_RFP Pro_RFP { get; set; }

        //public double GetBudgetryCulc(double Budgetry)
        //{

        //    double total = 0;
        //    total = total + Budgetry;

        //    return total;
        //}

        //    public String GetProValue(int value)
        //    {
        //        string valueString = null;
        //        switch (value)
        //        {
        //            case 1:
        //                valueString = "بسيط";
        //                break;

        //            case 2:
        //                valueString = "متوسط";
        //                break;

        //            case 3:
        //                valueString = "عالي";
        //                break;
        //        }
        //        return valueString;
        //    }


        //    public String GetProPeriorityColor(string getValue)
        //    {

        //        double value = double.Parse(getValue.Replace("%", ""));

        //        string valueString = null;
        //        switch (value)
        //        {
        //            case double n when (n >= 80):

        //                valueString = "ذات أولوية قصوى";
        //                break;

        //            case double n when (n >= 60 && n < 80):
        //                valueString = "ذات أولوية عالية";
        //                break;

        //            case double n when (n >= 40 && n < 60):
        //                valueString = "ذات أولوية وسطى";
        //                break;

        //            case double n when (n >= 20 && n < 40):
        //                valueString = "ذات أولوية منخفضة";
        //                break;

        //            case double n when (n < 20):
        //                valueString = "ذات أولوية منخفضة جداً";
        //                break;
        //        }
        //        return valueString;
        //    }

        //    public String GetProCost(int value)
        //    {
        //        string valueString = null;
        //        switch (value)
        //        {
        //            case 1:
        //                valueString = "منخفض";
        //                break;

        //            case 2:
        //                valueString = "متوسط";
        //                break;

        //            case 3:
        //                valueString = "عالي";
        //                break;
        //        }
        //        return valueString;
        //    }

        //    public String GetApprovalStatus(int value)
        //    {
        //        string valueString = null;
        //        switch (value)
        //        {
        //            case 0:
        //                valueString = "ليس في المسار";
        //                break;

        //            case 1:
        //                valueString = "جديد";
        //                break;

        //            case 2:
        //                valueString = "قيد الانجاز";
        //                break;

        //            case 3:
        //                valueString = "معتمد";
        //                break;

        //            case 4:
        //                valueString = "غير معتمد";
        //                break;
        //        }
        //        return valueString;
        //    }
        }

    }

  