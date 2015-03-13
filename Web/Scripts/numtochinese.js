$(document).ready(function () {
    $("#BorrowedAmount").blur(function () {
        var cont = $(this).val();
        if (cont == null || cont == "") {
            $("#AmountCapital").val();
            return;
        }
        var numRule = /^\d{0,9}\.?\d{0,2}$/;
        if (!numRule.test(cont)) {
            $("#AmountCapital").val();
            $(this).val("");
            return;
        };

        var num = parseFloat(cont, 10);

        cont = num + "";
        var before = null;
        var after = null;
        var result = "";
        var point = cont.indexOf(".");
        if (point == -1) {
            before = cont;
        } else {
            before = cont.substring(0, point);
            after = cont.substring(point + 1);
        }
        var temp = null;
        before = before.split("").reverse().join("");

        for (var i = 1; i <= before.length; i++) {
            if (i == 1 || i == 5) {
                temp = i == 5 ? "万" : "元";
                result = result.concat(temp);
                temp = getChineseNum(before.charAt(i - 1));
                result = result.concat(temp == "零" ? "" : temp);
            } else {
                temp = before.charAt(i - 1);
                if (temp == "0") {
                    result = result.concat("零");
                    continue;
                } else {
                    result = result.concat(getUnit(i).concat(getChineseNum(temp)));
                }
            }
        }
        result = result.split("").reverse().join("");

        var flag = true;
        while (flag) {
            if (result.indexOf("零零") != -1) {
                result = result.replace("零零", "零");
            } else {
                flag = false;
            }
        }

        if (result.indexOf("零万") != -1) {
            result = result.replace("零万", "万");
        }

        if (result.indexOf("零元") != -1) {
            result = result.replace("零元", "元");
        }

        if (after != null) {
            temp = getChineseNum(after.charAt(0));
            result = result.concat(temp == "零" ? "" : temp.concat("角"));
            temp = after.charAt(1);
            if (temp != null) {
                temp = getChineseNum(temp);
                result = result.concat(temp == "零" ? "" : temp.concat("分"));
            }
        }

        $("#AmountCapital").val(result);





    })
})

function getChineseNum(n) {
    switch (n) {
        case "1":
            return "壹";
            break;
        case "2":
            return "贰";
            break;
        case "3":
            return "叁";
            break;
        case "4":
            return "肆";
            break;
        case "5":
            return "伍";
            break;
        case "6":
            return "陆";
            break;
        case "7":
            return "柒";
            break;
        case "8":
            return "捌";
            break;
        case "9":
            return "玖";
            break;
        default:
            return "零";
            break;
    }
}

function getUnit(n) {
    switch (n) {
        case 1:
            return "元";
            break;
        case 2:
            return "拾";
            break;
        case 3:
            return "佰";
            break;
        case 4:
            return "仟";
            break;
        case 5:
            return "万";
            break;
        case 6:
            return "拾";
            break;
        case 7:
            return "佰";
            break;
        case 8:
            return "仟";
            break;
        default:
            return "亿";
            break;
    }
}