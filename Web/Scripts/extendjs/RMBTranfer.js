/**
         * 人民币大小写转换 Code_Tranfer.js
         * 作者： 王洪海
         * 时间： 2002-01-15.  
         * 函数入口    function getRMB( money)
            参数必须是有效的数字型字符串
            如果参数输入错误，返回"零圆零角零分"
         */

function getRMB(money) {
    var sReturn = "";
    var monint = "";
    var monfloat = "";
    var moneys = "";
    var i = 0;
    var k = 0;
    var j = 0;
    var temp = "";
    var total = "";
    var unit = new Array("分", "角", "元", "拾", "佰", "仟", "万", "拾", "佰", "仟", "亿", "拾", "佰", "仟");

    sReturn = "零圆零角零分";

    if (isNumeric(money) == false)
        return sReturn;
    try {
        money = getFormat(money);

        if (money == "0.00") {
            return "零元整";
        }

        i = money.indexOf(".");

        monint = leftTrim(money, i);
        monfloat = money.substring(i + 1);

        if (monint.charAt(0) == "-") {
            monint = monint.substring(1);
        }
        moneys = monint + monfloat;
        k = moneys.length;
        j = 0;
        var i = k;
        for (i = k ; i >= 1 ; i--) {
            temp = moneys.substring(i - 1, i);
            if (numToChn(temp) != "零") {
                total = numToChn(temp) + unit[k - i] + total;
                j = 0;
            }
            else if ((unit[k - i] == "元") || (unit[k - i] == "万") || (unit[k - i] == "亿") && (numToChn(temp) == "零")) {
                total = unit[k - i] + total;
                j = 1;
            }
            else {
                if (j == 0) {
                    total = "零" + total;
                    j = 1;
                }
            }
        }

        for (i = 1; i <= total.length / 2; i++) {
            temp = rightTrim(total, 2 * i);
            if (leftTrim(temp, 1) != "零") {
                break;
            }
        }
        total = leftTrim(total, total.length - 2 * (i - 1));
        if (rightTrim(total, 1) == "零") {
            total = leftTrim(total, total.length - 1);
        }
        var firstTotal = rightTrim(total, 1);
        if (firstTotal == "角") {
            total = total + "整";
        }
        else if (firstTotal == "分")
        { }
        else if (firstTotal == "元") {
            total = total + "整";
        }
        else
            total = total + "元整";
        if (leftTrim(total, 1) == "元") {
            total = "零" + total;
        }
        sReturn = total;
    } catch (e) {
        sReturn = "零圆零角零分";
    }
    return sReturn;

}
//左截取函数
function leftTrim(m_strVal, nTrim) {
    return m_strVal.substring(0, nTrim);
}

//右截取函数
function rightTrim(m_strVal, nTrim) {
    var nLength = m_strVal.length;
    return m_strVal.substring(nLength - nTrim, nLength);
}
//将数字转换成"0.00"格式
function getFormat(strValue) {
    var sResult = "0.00";
    var nPos = 0;
    var nLength = 0;
    nLength = strValue.length;
    nPos = strValue.indexOf(".");
    var nDecimal = nLength - nPos;
    if (nPos < 0)
        sResult = strValue + ".00";
    else if (nPos == 0)
        sResult = "0" + strValue;
    else if (nDecimal == 0)
        sResult = strValue + "00";
    else if (nDecimal == 1) {
        sResult = strValue + "00";
    }
    else if (nDecimal == 2) {
        sResult = strValue + "0";
    }
    else if (nDecimal == 3) {
        sResult = strValue;
    }
    else if (nDecimal > 2) {
        sResult = strValue.substring(0, nPos + 3);
    }
    return sResult;
}

//判断一个字符串是否都是数字，是--true,否--false
function isNumeric(m_strVal) {
    var m_strInt = "0123456789-.";

    var nLength = m_strVal.length;
    for (i = 0; i < nLength ; i++) {
        var s = m_strVal.charAt(i);
        var nPos = m_strInt.indexOf(s);
        if (nPos < 0) {
            return false;
        }
    }
    return true;
}

function numToChn(num) {
    var strUpper = "零壹贰叁肆伍陆柒捌玖";
    var nReturn = "";
    try {
        var i = num;
        if (i < 10 && i >= 0) {
            //nReturn = strUpper.substring(i,i+1);
            nReturn = strUpper.charAt(i);
        }
        else
            nReturn = "";
    } catch (e) {
        nReturn = "";
    }
    return nReturn;
}