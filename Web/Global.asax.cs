using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Timers;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using System.Web.Http;

namespace Web
{
    // 注意: 有关启用 IIS6 或 IIS7 经典模式的说明，
    // 请访问 http://go.microsoft.com/?LinkId=9394801

    public class MvcApplication : System.Web.HttpApplication
    {
        private System.Timers.Timer myTimer = null;

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();

            WebApiConfig.Register(GlobalConfiguration.Configuration);
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            

            //用Scripts和Styles将脚本和样式表引入页面时，无需修改任何代码就可以将脚本和样式表编译压缩输入到客户端，   
            //这样不仅可以有效的增加JSHack的难度以及降低文件的大小。为了达到这个目的，我们只需要将BundleTable中的一个属性设置为true即可
            BundleTable.EnableOptimizations = true;

            BundleConfig.RegisterBundles(BundleTable.Bundles);
            myTimer = new System.Timers.Timer(Convert.ToInt32(Tool.ReadAppSitting("clearzhanwei")));
//自动化任务，每1分钟执行一次
            //myTimer.Elapsed += new ElapsedEventHandler(myTimer_Elapsed);
            myTimer.Enabled = true;
            myTimer.AutoReset = true;
           
        }

        //private void myTimer_Elapsed(object source, ElapsedEventArgs e)
        //{
        //    myTimer.Enabled = false;
        //    try
        //    {
        //        //设置过期订单
        //        BLL.IBLL DB = new BLL.IBLL();
        //        //DB.I_Orders.ExecNonSql("update Orders set OrderState=8 where PayDate<'" + DateTime.Now + "' and OrderState<2");
        //        DateTime nowDate = DateTime.Now;
        //        var Result = DB.I_Orders.GetListBy(s => s.PayDate < nowDate && s.OrderState < 2).ToList();
        //        //要更新的团期
        //        List<MODEL.GroupStage> updateGroup = new List<MODEL.GroupStage>();
        //        for (int i = 0; i < Result.Count; i++)
        //        {
        //            DB = new BLL.IBLL();
        //            var model = Result[i];
        //            model.OrderState = 8;
        //            //MODEL.LineSchedule scheduleModel = model.LineSchedule;
        //            MODEL.LineSchedule scheduleModel=DB.I_LineSchedule.GetSingleModelBy(s => s.LineScheduleId == model.LineScheduleId);
        //            model.LineScheduleId = null;
        //            if (!updateGroup.Contains(model.GroupStage))
        //            {
        //                updateGroup.Add(model.GroupStage);
        //            }
        //            DB.I_Orders.Modify(model, "OrderState","LineScheduleId");
        //            if(scheduleModel==null )
        //            {                       
        //                continue;
        //            }
        //            MODEL.OnlineChat messageModel = new MODEL.OnlineChat();
        //            string gno = scheduleModel.GroupStage.GroupNumber;
        //            messageModel.BusinessManId = model.BusinessManId;
        //            messageModel.MessageTitle = gno + "占位超时取消";
        //            messageModel.SupplierId = model.GroupStage.TravelProduct.SupplierId;
        //            messageModel.MessageType = 2;
        //            messageModel.IsRead = false;

        //            messageModel.ExchangeInfo = "您好，您预订的<a href='/RetailSales/GroupStageInfo/" + scheduleModel.GroupStageId + "' target=_blank>" + gno + scheduleModel.GroupStage.TravelProduct.LineName + scheduleModel.TravelDate.Value.ToString("yyyy-MM-dd") + "</a>"  // "到" + item.GroupStage.TravelProduct.ObjectiveCity + "的" +              +item.GroupStage.TravelProduct.LineName 
        //                    + "因超时未付款，原占位自动取消！<br/>"
        //                    + "如有任何问题您可以随时联系我们网站客服人员，或者拨打我们的客服电话：" + Tool.ReadAppSitting("servicephone") + "。";


        //            //messageModel.ExchangeInfo = "您好，您预订的" + scheduleModel.TravelDate.Value.ToString("yyyy-MM-dd") + "到" + model.GroupStage.TravelProduct.ObjectiveCity + "的" + model.GroupStage.TravelProduct.LineName + "占位超时未付款，系统将自动删除，如有疑问请联系客服！";//ERROR!!
        //            DB.I_OnlineChat.Add(messageModel);
        //            DB.I_LineSchedule.DelBy(s => s.LineScheduleId == model.LineScheduleId);
        //        }
        //        //排除升为占位
        //        foreach (var item in updateGroup)
        //        {
        //            ResetZhanWei(item);
        //        }
        //    }
        //    catch {
        //        myTimer.Enabled = true;
        //    }
        //    myTimer.Enabled = true;
        //}

        //private void ResetZhanWei(MODEL.GroupStage gModel)
        //{
        //    BLL.IBLL DB = new BLL.IBLL();
        //    var SucessList = DB.I_LineSchedule.GetListBy(s => s.SeatLock == true && s.GroupStageId == gModel.GroupStageId).Select(s => new { s.Children, s.Adult }).ToList();
        //    //剩余位
        //    int LeftCount = gModel.PlanBit.Value - SucessList.Sum(s => s.Adult).Value - SucessList.Sum(s => s.Children).Value;
        //    //转换排队订单为占位订单
        //    var PaiDuiList = DB.I_LineSchedule.GetListBy(s => s.SeatLock == false && s.GroupStageId == gModel.GroupStageId).OrderBy(s => s.LineScheduleId).ToList();
        //    if (LeftCount > 0)
        //    {
        //        for (int i = 0; i < PaiDuiList.Count; i++)
        //        {
        //            var item = PaiDuiList[i];
        //            int pCount = item.Adult.Value + item.Children.Value;
        //            if (LeftCount >= pCount)
        //            {
        //                item.SeatLock = true;
        //                item.ScheduleDate = DateTime.Now.ToShortDateString().ToDate();
        //                if (DB.I_LineSchedule.Modify(item, "SeatLock", "ScheduleDate"))
        //                {
        //                    //排队成功,发送消息;
        //                    MODEL.OnlineChat messageModel = new MODEL.OnlineChat();
        //                    messageModel.BusinessManId = item.BusinessManId;

        //                    messageModel.IsRead = false;
        //                    messageModel.MessageType = 2;
        //                    messageModel.SupplierId = item.GroupStage.TravelProduct.SupplierId;
        //                    string gno = item.GroupStage.GroupNumber;
        //                    messageModel.MessageTitle = gno+"由排队转为占位";
        //                    messageModel.ExchangeInfo = "您好，您预订的<a href='/RetailSales/GroupStageInfo/" + item.GroupStage.GroupStageId + "' target=_blank>" + gno + item.GroupStage.TravelProduct.LineName + item.TravelDate.Value.ToString("yyyy-MM-dd") // "到" + item.GroupStage.TravelProduct.ObjectiveCity + "的" +              +item.GroupStage.TravelProduct.LineName 
        //                    + "</a>由排队转为占位，请及时<a href='/RetailSales/PayDetails?orderno=" + item.Orders.First().OrderNumber + "' target=_blank>付款</a>，超时未付款占位将自动取消！<br/>"
        //                    +"如有任何问题您可以随时联系我们网站客服人员，或者拨打我们的客服电话："+Tool.ReadAppSitting("servicephone")+"。";
                            
        //                    //添加定单
        //                    MakeOrder(item);
        //                    DB.I_OnlineChat.Add(messageModel);
        //                    LeftCount = LeftCount - pCount;
        //                }
        //            }
        //        }
        //    }
        //}

        //public bool MakeOrder(MODEL.LineSchedule lstzhan)
        //{
        //    BLL.IBLL DB = new BLL.IBLL();
        //    var gsmodel = lstzhan.GroupStage;
        //    //此处创建订单
        //    MODEL.Orders model = new MODEL.Orders();
        //    model.OrderDate = DateTime.Now;
        //    //model.LineScheduleId = lstzhan.LineScheduleId;
        //    model.AdultNum = lstzhan.Adult;//成人
        //    model.ChildrenNum = lstzhan.Children;//儿童
        //    model.AllLineCode = gsmodel.TravelProduct.LineNumber;//;//多个线路号,后续考虑订单合并付款的情况
        //    model.BusinessManId = lstzhan.BusinessManId;
        //    model.GroupStageId = lstzhan.GroupStageId;//团号
        //    model.LineId = gsmodel.LineId;//线路id
        //    model.OccupyingState = true;
        //    //model.OrderNumber = ExtendClass.GetOrderNo();//订单号自动生成
        //    model.OrderState = 0;// "下单";(订单状态(0, 订单生成;1,等待付款;2.已付款;3.交易成功;4.申请退款中;5.等待处理退款;6.已退款;7.订单取消;8. 订单失效;)
        //    model.PayAmount = gsmodel.AdultPrice * lstzhan.Adult + gsmodel.ChildrenPrice * lstzhan.Children;//总价
        //    model.OrderType = "";//订单类型
        //    model.PayDate = DateTime.Now.AddHours(gsmodel.OccupationOverTime.Value);//支付时间
        //    if (model.PayDate > gsmodel.EndRegistration)
        //    {
        //        model.PayDate = gsmodel.EndRegistration.Value;
        //    }
        //    model.PayState = false;//未付
        //    model.Receivable = model.PayAmount;//应收
        //    model.StoreNumber = lstzhan.BusinessMan.StoreNumber;//门市号
        //    model.SupplierId = gsmodel.TravelProduct.SupplierId;
        //    model.TradePrice = model.PayAmount;//成交价,确认价格不更新后才算成交

        //    if (DB.I_Orders.Add(model))
        //    {
        //        //发信息
        //        MODEL.OnlineChat nmodel = new MODEL.OnlineChat();
        //        string mtitle = gsmodel.GroupNumber +gsmodel.TravelProduct.LineName + Convert.ToDateTime(gsmodel.OutDate).ToShortDateString();
        //        nmodel.MessageTitle = gsmodel.GroupNumber + "占位成功";
        //        nmodel.BusinessManId = DB.I_BusinessMan.GetLoginInfo().BusinessManId;
        //        nmodel.IsRead = false;
        //        nmodel.MessageType = 2;
        //        nmodel.ExchangeInfo = "您好，您提交的<a href='/RetailSales/GroupStageInfo/" + gsmodel.GroupStageId + "' target=_blank>" + mtitle + "</a>已占位成功，请及时<a href='/RetailSales/PayDetails?orderno=" + model.OrderNumber + "' target=_blank>付款</a>，超时未付款占位将自动取消！<br/>如有任何问题您可以随时联系我们网站客服人员，或者拨打我们的客服电话：" + Tool.ReadAppSitting("servicephone") + "。";
        //        nmodel.PostDate = DateTime.Now;
        //        DB.I_OnlineChat.Add(nmodel);
        //        return true;
        //    }
        //    return false;
        //}
    }
}