using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using MvcApplication1.Models.ViewModel;
namespace MvcApplication1.Models
{
    public class TestData
    {

       /// <summary>
       /// 模板数据（用于生成页面）
       /// </summary>
       /// <param name="number"></param>
       /// <returns></returns>
        public PublicResult GetTemplateData(string number)
        {
            PublicResult result = new PublicResult();
            using (var db = new  testdbEntities2())
            {
                var template =  db.dataTemplate.FirstOrDefault(m=>m.number==number);
                
                result.IsSuccess = true;
                result.Data = template;
            }

            return result;
        }
        /// <summary>
        /// 根据模板添加数据
        /// </summary>
        /// <param name="dataPara"></param>
        /// <returns></returns>
        public PublicResult addData(data dataPara)
        {
            PublicResult result = new PublicResult();
           
          
            using(var db = new testdbEntities2())
            {
                              
                db.data.Add(dataPara);
                if (db.SaveChanges() > 0)
                {
                    result.IsSuccess = true;
                    result.Message = "添加成功";
                }
            
            }
            return result;
        }
        /// <summary>
        /// 根据模板编号和字段key返回对应的数据
        /// </summary>
        /// <param name="number"></param>
        /// <param name="attrKey"></param>
        /// <returns></returns>
        public PublicResult getData(string number,string attrKey)
        {
            PublicResult result = new PublicResult();
            if (string.IsNullOrEmpty(number))
            {
                result.Message = "number不能为空";
                return result;
            }
            using (var db = new testdbEntities2())
            {
                var lstData = db.data.Where(m => m.number == number).ToList();

                if (lstData != null && lstData.Count > 0)
                {
                    if (!string.IsNullOrEmpty(attrKey))
                    {

                        for (int i = lstData.Count-1; i >=0 ;i-- )
                        {
                            List<FieldObj> lstFieldObj =  JsonConvert.DeserializeObject<List<FieldObj>>(lstData[i].jsonData);
                            var field = lstFieldObj.FirstOrDefault(m => m.attrkey == attrKey);
                            if (field == null)
                            {
                                lstData.RemoveAt(i);
                            }
                            
                        }
                        
                        
                    }
                   
                    result.IsSuccess = true;
                    result.Data = lstData;
                }
            }
            return result;

        }

        public PublicResult getAllData()
        {
            PublicResult result = new PublicResult();

            using(var db=new testdbEntities2())
            {
               
                result.Data = db.data.ToList();
                result.IsSuccess = true;
            }
            return result;
        
        }
    }
}