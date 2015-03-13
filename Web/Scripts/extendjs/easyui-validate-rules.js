$.extend($.fn.validatebox.defaults.rules, {
    CHS: {
        validator: function (value, param) {
            return /^[\u0391-\uFFE5]+$/.test(value);
        },
        message: '请输入汉字'
    },
    EN: {
        validator: function (value, param) {
            return /^[A-Za-z]+$/.test(value);
        },
        message: '请输入英文字母'
    },
    ZIP: {
        validator: function (value, param) {
            return /^[1-9]\d{5}$/.test(value);
        },
        message: '邮政编码不存在'
    },
    QQ: {
        validator: function (value, param) {
            return /^[1-9]\d{4,10}$/.test(value);
        },
        message: 'QQ号码不正确'
    },
    mobile: {
        validator: function (value, param) {
            return /^((\(\d{2,3}\))|(\d{3}\-))?1\d{10}$/.test(value);
        },
        message: '手机号码不正确'
    },
    phone: {
        validator: function (value, param) {
            return /\d{3}-\d{8}|\d{4}-\d{7}/.test(value);
        },
        message: '电话或传真号码不正确，如：010-51108888或0316-6546889'
    },
    loginName: {
        validator: function (value, param) {
            return /^[\u0391-\uFFE5\w]+$/.test(value);
        },
        message: '登录名称只允许汉字、英文字母、数字及下划线。'
    },
    safepass: {
        validator: function (value, param) {
            return safePassword(value);
        },
        message: '密码由字母和数字组成，至少6位'
    },
    equals: {//例：validtype="equals[$('#newpwd1').val()]",其中newpwd1为控件ID
        validator: function (value, param) {
            return value == $('#'+param[0]).val();
        },
        message: '两次输入的字符不一致'
    },
    IP: {
        validator: function (value, param) {
            return /\d+\.\d+\.\d+\.\d+$/.test(value);
        },
        message: 'IP地址不正确，如：61.128.128.68'
    },
    //远程验证remote[4,'/Control/UserHandler.ashx?username=','username','账户名']
    remote: {//remote[位数, 远程验证文件, 命名, 正则格式要求，正则格式提示,参数3可选]
        validator: function (value, param) {
            if (value.length < param[0]) {
                $.fn.validatebox.defaults.rules.remote.message = '至少要有' + param[0] + '个字符！';
                return false;
            } else {
                if (param[3].length != 0) {
                    var reg = new RegExp(param[3]); //其它正则格式要求
                    if (!reg.test(value)) {
                        $.fn.validatebox.defaults.rules.remote.message = '用户名只能英文字母、数字及下划线的组合！';
                        return false;
                    }
                }

                var postdata = {};
                if (param[3]) {
                    postdata[param[2]] = param[3];
                } else {
                    postdata[param[2]] = value;
                }
                var result = $.ajax({
                    url: param[1],
                    data: postdata,
                    type: 'post',
                    dataType: 'json',
                    async: false,
                    cache: false
                }).responseText;
                if (result == 'false') {
                    $.fn.validatebox.defaults.rules.remote.message = '相同数据已存在！';
                    return false;
                } else {
                    return true;
                }
            }
        },
        message: ''
    },
    CnEnNum: {//中英文或数字
        validator: function (value, param) {
            return /^[A-Za-z0-9\u0391-\uFFE5]+$/.test(value);
        },
        message: '请输入中英文或数字'
    },

    EnNum: {//英文或数字
        validator: function (value, param) {
            return /^[A-Za-z0-9]+$/.test(value);
        },
        message: '请输入英文或数字'
    },
    //各种数字验证
    number: {
        validator: function (value, param) {
            return /^\d+$/.test(value) || /^-?([1-9]\d*\.\d*|0\.\d*[1-9]\d*|0?\.0+|0)$/.test(value);
        },
        message: '请输入数字'
    },
    Int: {//整数
        validator: function (value, param) {
            return /^-?[1-9]\d*$/.test(value);
        },
        message: '请输入整数数字'
    },
    pInt: {//正整数
        validator: function (value, param) {
            return /^[1-9]\d*$/.test(value);
        },
        message: '请输入大于0的整数'
    },
    nInt: {//负整数
        validator: function (value, param) {
            return /^-[1-9]\d*$/.test(value);
        },
        message: '请输入小于0的整数'
    },
    nnInt: {//非负整数
        validator: function (value, param) {
            return /^[1-9]\d*|0$/.test(value);
        },
        message: '请输入大于或等于0的整数'
    },
    npInt: {//非正整数
        validator: function (value, param) {
            return /^-[1-9]\d*|0$/.test(value);
        },
        message: '请输入小于或等于0的整数'
    },
    pFloat: {//正浮点数
        validator: function (value, param) {
            return /^[1-9]\d*\.\d*|0\.\d*[1-9]\d*$/.test(value);
        },
        message: '请输入大于0的小数'
    },
    nFloat: {//负浮点数
        validator: function (value, param) {
            return /^-([1-9]\d*\.\d*|0\.\d*[1-9]\d*)$/.test(value);
        },
        message: '请输入小于0的小数'
    },
    Float: {//浮点数
        validator: function (value, param) {
            return /^-?([1-9]\d*\.\d*|0\.\d*[1-9]\d*|0?\.0+|0)$/.test(value);
        },
        message: '请输入小数'
    },
    nnFloat: {//非负浮点数
        validator: function (value, param) {
            return /^[1-9]\d*\.\d*|0\.\d*[1-9]\d*|0?\.0+|0$/.test(value);
        },
        message: '请输入大于等于0的小数'
    },
    npFloat: {//非正浮点数
        validator: function (value, param) {
            return /^(-([1-9]\d*\.\d*|0\.\d*[1-9]\d*))|0?\.0+|0$/.test(value);
        },
        message: '请输入小于等于0的小数'
    },


    idcard: {
        validator: function (value, param) {
            return idCard(value);
        },
        message:'请输入正确的身份证号码'
    }



});

/* 密码由字母和数字组成，至少6位 */
var safePassword = function (value) {
    return !(/^(([A-Z]*|[a-z]*|\d*|[-_\~!@#\$%\^&\*\.\(\)\[\]\{\}<>\?\\\/\'\"]*)|.{0,5})$|\s/.test(value));
}

var idCard = function (value) {
    if (value.length == 18 && 18 != value.length) return false;
    var number = value.toLowerCase();
    var d, sum = 0, v = '10x98765432', w = [7, 9, 10, 5, 8, 4, 2, 1, 6, 3, 7, 9, 10, 5, 8, 4, 2], a = '11,12,13,14,15,21,22,23,31,32,33,34,35,36,37,41,42,43,44,45,46,50,51,52,53,54,61,62,63,64,65,71,81,82,91';
    var re = number.match(/^(\d{2})\d{4}(((\d{2})(\d{2})(\d{2})(\d{3}))|((\d{4})(\d{2})(\d{2})(\d{3}[x\d])))$/);
    if (re == null || a.indexOf(re[1]) < 0) return false;
    if (re[2].length == 9) {
        number = number.substr(0, 6) + '19' + number.substr(6);
        d = ['19' + re[4], re[5], re[6]].join('-');
    } else d = [re[9], re[10], re[11]].join('-');
    if (!isDateTime.call(d, 'yyyy-MM-dd')) return false;
    for (var i = 0; i < 17; i++) sum += number.charAt(i) * w[i];
    return (re[2].length == 9 || number.charAt(17) == v.charAt(sum % 11));
}

var isDateTime = function (format, reObj) {
    format = format || 'yyyy-MM-dd';
    var input = this, o = {}, d = new Date();
    var f1 = format.split(/[^a-z]+/gi), f2 = input.split(/\D+/g), f3 = format.split(/[a-z]+/gi), f4 = input.split(/\d+/g);
    var len = f1.length, len1 = f3.length;
    if (len != f2.length || len1 != f4.length) return false;
    for (var i = 0; i < len1; i++) if (f3[i] != f4[i]) return false;
    for (var i = 0; i < len; i++) o[f1[i]] = f2[i];
    o.yyyy = s(o.yyyy, o.yy, d.getFullYear(), 9999, 4);
    o.MM = s(o.MM, o.M, d.getMonth() + 1, 12);
    o.dd = s(o.dd, o.d, d.getDate(), 31);
    o.hh = s(o.hh, o.h, d.getHours(), 24);
    o.mm = s(o.mm, o.m, d.getMinutes());
    o.ss = s(o.ss, o.s, d.getSeconds());
    o.ms = s(o.ms, o.ms, d.getMilliseconds(), 999, 3);
    if (o.yyyy + o.MM + o.dd + o.hh + o.mm + o.ss + o.ms < 0) return false;
    if (o.yyyy < 100) o.yyyy += (o.yyyy > 30 ? 1900 : 2000);
    d = new Date(o.yyyy, o.MM - 1, o.dd, o.hh, o.mm, o.ss, o.ms);
    var reVal = d.getFullYear() == o.yyyy && d.getMonth() + 1 == o.MM && d.getDate() == o.dd && d.getHours() == o.hh && d.getMinutes() == o.mm && d.getSeconds() == o.ss && d.getMilliseconds() == o.ms;
    return reVal && reObj ? d : reVal;
    function s(s1, s2, s3, s4, s5) {
        s4 = s4 || 60, s5 = s5 || 2;
        var reVal = s3;
        if (s1 != undefined && s1 != '' || !isNaN(s1)) reVal = s1 * 1;
        if (s2 != undefined && s2 != '' && !isNaN(s2)) reVal = s2 * 1;
        return (reVal == s1 && s1.length != s5 || reVal > s4) ? -10000 : reVal;
    }
};


/*
中文汉字=CHS=仅支持中文汉字！
身份证号=idcard=请输入标准的身份证号码！
电话传真=phone=如：010-51108888或0316-6546889
手机号码=mobile=支持13、15、18开头的手机号！
邮政编码=ZIP
英文字母=EN=请输入英文字母=^[A-Za-z]+$
ip地址=IP=\d+\.\d+\.\d+\.\d+=如：61.128.128.68
QQ号=QQ
Email=email
网址=url
登录名=loginName=可以是4-15位英文、下划线和数字的组合
密码=safepass
比较=equals
远程验证=remote
===========
中文汉字=^[\u4e00-\u9fa5]{0,}$
身份证号=[\d]{6}(19|20)*[\d]{2}((0[1-9])|(11|12))([012][\d]|(30|31))[\d]{3}[xX\d]*
电话传真=\d{3}-\d{8}|\d{4}-\d{7}=如：010-51108888或0316-6546889
手机号码=[1][3,5,8]\d{9}=支持13、15、18开头的手机号！
邮政编码=[1-9]\d{5}(?!\d)
英文字母=^[A-Za-z]+$
ip地址=\d+\.\d+\.\d+\.\d+=如：61.128.128.68
QQ号=[1-9][0-9]{4,}
Email=\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*=如：cqniit@126.com
网址=[a-zA-z]+://[^\s]*=如：http://www.google.com
账号=^[a-zA-Z][a-zA-Z0-9_]{4,15}$=可以是4-15位英文、下划线和数字的组合
远程验证
--------------------------------------------------------------
正整数=pInt=^[1-9]\d*$
负整数=nInt=^-[1-9]\d*$
整数=Int=^-?[1-9]\d*$
非负整数=nnInt=^[1-9]\d*|0$
非正整数=npInt=^-[1-9]\d*|0$
正浮点数=pFloat=^[1-9]\d*\.\d*|0\.\d*[1-9]\d*$
负浮点数=nFloat=^-([1-9]\d*\.\d*|0\.\d*[1-9]\d*)$
浮点数=Float=^-?([1-9]\d*\.\d*|0\.\d*[1-9]\d*|0?\.0+|0)$
非负浮点数=nnFloat=^[1-9]\d*\.\d*|0\.\d*[1-9]\d*|0?\.0+|0$
非正浮点数=npFloat=^(-([1-9]\d*\.\d*|0\.\d*[1-9]\d*))|0?\.0+|0$

*/

//这一段JS 是必不可少的
/*

$(function () {
$('#uiform input').each(function () {
if ($(this).attr('required') || $(this).attr('validType'))
$(this).validatebox();
})
});
*/
//如果在提交时验证表单有没有通过验证，则可使用下面的代码
/*
var flag = true;

$('#uiform input').each(function () {
if ($(this).attr('required') || $(this).attr('validType')) {
if (!$(this).validatebox('isValid')) {
flag = false;
return;
}
}
})

if (flag)
alert('验证通过！');
else
alert('验证失败！');
*/

/*
equalTo 的使用方法如下：
<input type="password" id="txtpasswd" />
<input type="password" id="txtpasswd2" validType="equals['#txtpasswd']" />
*/

/*例：
中文汉字=CHS
身份证号=idcard
电话传真=phone
手机号码=mobile
邮政编码=ZIP
英文字母=EN
ip地址=IP
QQ号=QQ
Email=email
网址=url
登录名=loginName
密码=safepass
比较=equals['#txtpasswd']
远程验证=remote
-----
正整数=pInt=^[1-9]\d*$
负整数=nInt=^-[1-9]\d*$
整数=Int=^-?[1-9]\d*$
非负整数=nnInt=^[1-9]\d*|0$
非正整数=npInt=^-[1-9]\d*|0$
正浮点数=pFloat=^[1-9]\d*\.\d*|0\.\d*[1-9]\d*$
负浮点数=nFloat=^-([1-9]\d*\.\d*|0\.\d*[1-9]\d*)$
浮点数=Float=^-?([1-9]\d*\.\d*|0\.\d*[1-9]\d*|0?\.0+|0)$
非负浮点数=nnFloat=^[1-9]\d*\.\d*|0\.\d*[1-9]\d*|0?\.0+|0$
非正浮点数=npFloat=^(-([1-9]\d*\.\d*|0\.\d*[1-9]\d*))|0?\.0+|0$
通用正则=regx['^[a-zA-Z][a-zA-Z0-9_]{4,15}$','账号可以是4-15位英文、下划线和数字的组合']
*/