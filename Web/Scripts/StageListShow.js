var typename = new Array("", "供应商", "同业价格", "建议价格");
if ($.cookie('a1') == 1) {
    $("th[name='gys1']").hide();
    $("td[name='gys1']").each(function () {
        $(this).hide();
    });
    $("#showhide1").val(1);
    $("#shimg1").attr("alt", "显示" + typename[1]);
    $("#shimg1").attr("title", "显示" + typename[1]);
}
if ($.cookie('a2') == 1) {
    $("th[name='gys2']").hide();
    $("td[name='gys2']").each(function () {
        $(this).hide();
    });
    $("#showhide2").val(1);
    $("#shimg2").attr("alt", "显示" + typename[2]);
    $("#shimg2").attr("title", "显示" + typename[2]);
}
if ($.cookie('a3') == 1) {
    $("th[name='gys3']").hide();
    $("td[name='gys3']").each(function () {
        $(this).hide();
    });
    $("#showhide3").val(1);
    $("#shimg3").attr("alt", "显示" + typename[3]);
    $("#shimg3").attr("title", "显示" + typename[3]);
}

function stagelistshow(id) {
    var type = $("#showhide" + id).val();
    var wori = $('tbody tr .n2');//.find('.n2');
    var showWidth = 0;
    var hideWidth = 0;
    if (type == 0) {
        hideWidth = 0;
        showWidth = 0;
        if (id == 1) {
            $("th[name='gys1']").hide(300);
            $("td[name='gys1']").each(function () {
                $(this).hide(300);
                //setTimeout("hideWidth = $('th[name=gys1]').width()",350);
                //hideWidth = $("th[name='gys1']").width();
                //changewidth("table tr [name=proname]", $("table tr [name=proname1]").width() );
            });
        }
        else if (id == 2) {
            $("th[name='gys2']").hide(300);
            $("td[name='gys2']").each(function () {
                $(this).hide(300);
                //setTimeout("hideWidth = $('th[name=gys2]').width()", 350);
                //changewidth("table tr [name=proname]", $("table tr [name=proname1]").width());
                hideWidth = $("th[name='gys2']").width();
            });
        }
        else {
            $("th[name='gys3']").hide(300);
            $("td[name='gys3']").each(function () {
                $(this).hide(300);
                //setTimeout("hideWidth = $('th[name=gys3]').width()", 350);
                
                //hideWidth = $("th[name='gys3']").width();
               
            });
        }
        changewidth("table tr [name=proname]", $("table tr [name=proname1]").width());

        //alert("hide后这个的宽度是：" + hideWidth + "\n得到的宽度是：" + $('.head tr th').eq(1).width());
        $("#showhide" + id).val(1);
        $("#shimg" + id).attr("alt", "显示" + typename[id]);
        $("#shimg" + id).attr("title", "显示" + typename[id]);
        $.cookie('a' + id, 1);
    }
    else {
        showWidth = 0;
        hideWidth = 0;
        if (id == 1) {
            $("th[name='gys1']").show(300);
            $("td[name='gys1']").each(function () {
                $(this).show(300);
                //setTimeout("showWidth = $('th[name=gys1]').width()", 350);
                // changewidth("table tr [name=proname]", $("table tr [name=proname1]").width());
            });
            
            //showWidth = $("th[name='gys1']").width();
        }
        else if (id == 2) {
            $("th[name='gys2']").show(300);
            $("td[name='gys2']").each(function () {
                $(this).show(300);
                //setTimeout("showWidth = $('th[name=gys2]').width()", 350);
                //changewidth("table tr [name=proname]", $("table tr [name=proname1]").width());
            });
            //showWidth = $("th[name='gys2']").width();
            
            $.cookie('a1', 1, { expires: 7, secure: true });
        }
        else {
            $("th[name='gys3']").show(300);
            $("td[name='gys3']").each(function () {
                $(this).show(300);
                // setTimeout("showWidth = $(" + "'th[name=" + "gys3" + "]').width()", 350);
                
            });
            //showWidth = $("th[name='gys3']").width();
            //changewidth("table tr [name=proname]", $("table tr [name=proname1]").width() );
        }
        //alert("show后这个的宽度是：" + wori.width() + "\n得到的宽度是：" + $('.head tr th').eq(1).width());
        changewidth("table tr [name=proname]", $("table tr [name=proname1]").width());

        $("#showhide" + id).val(0)
        $("#shimg" + id).attr("alt", "隐藏" + typename[id]);
        $("#shimg" + id).attr("title", "隐藏" + typename[id]);
        $.cookie('a' + id, 0);
    }
    //setTimeout(" layer.alert('show=' + showWidth + ',hide=' + hideWidth,4)", 350);
    //setTimeout("$('tbody tr .n2').each(function (index) {$('tbody tr .n2').eq(index).width($('tbody tr .n2').width() + hideWidth - showWidth);})", 500);
    //setTimeout("changewidth('tbody tr .n2', showWidth, hideWidth)", 300);
    //changewidth('tbody tr .n2', showWidth, hideWidth);
    //setTimeout("wori.width(wori.width() + hideWidth - showWidth)", 500);
}
function changewidth(em, hidewidth) {
    //layer.alert("hidewidth=" + hidewidth,2);
    $(em).each(function (index) {
        //$(em).eq(index).width($(em).width() + hidewidth - showhide);
        $(em).eq(index).width(hidewidth)
        layer.alert($(em).eq(index).width());
    });
}