using Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Models
{
    public class BaseResponse
    {
        public string msg { set; get; }
        public int code { set; get; }
        public object data { set; get; } = null;
        public static BaseResponse Success()
        {
            BaseResponse baseResponse = new BaseResponse();

            baseResponse.code = (int)CodeEnum.成功;
            baseResponse.msg = CodeEnum.成功.ToString();
            return baseResponse;
        }
        public static BaseResponse Error()
        {
            BaseResponse baseResponse = new BaseResponse();
            baseResponse.code = (int)CodeEnum.失败;
            baseResponse.msg = CodeEnum.失败.ToString();
            return baseResponse;
        }

        public static BaseResponse Error(CodeEnum codeEnum)
        {
            BaseResponse baseResponse = new BaseResponse();
            baseResponse.code = (int)codeEnum;
            baseResponse.msg = codeEnum.ToString();
            return baseResponse;
        }

        public static BaseResponse Success(object result)
        {
            BaseResponse baseResponse = new BaseResponse();
            baseResponse.code = (int)CodeEnum.成功;
            baseResponse.msg = CodeEnum.成功.ToString();
            baseResponse.data = result;
            return baseResponse;
        }

    }

}