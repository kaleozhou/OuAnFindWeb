// JavaScript Document

$(function(){
	//根据字体大小来调节信息框的宽度
	var msgwidth = parseInt($('.textall').css('font-size'))*$('.mytext').text().length;
	if(msgwidth<190){
		$('.mytext').css('width',msgwidth+'px');
		}else{
			$('.mytext').css('width','190px');
		}
	if(parseInt($('#mytext').css('height'))>36){
			$('.myarrimg').css('margin-top','10px');
		}else{
			$('.myarrimg').css('margin-top','-1px');
		}	
	var comwidth =parseInt($('.textall').css('font-size'))*$('.comsumertext').text().length;	
	if(comwidth<190){
		$('.comsumertext').css('width',comwidth+'px');
		}else{
			$('.comsumertext').css('width','190px');
		}
	if(parseInt($('.comsumertext').css('height'))>36){
			$('.comsarrimg').css('margin-top','10px');
		}else{
			$('.comsarrimg').css('margin-top','-1px');
		}
});