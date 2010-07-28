function loadDatepicker(element)
{
    $(element).datepicker({
        showOn: 'both'
        , buttonImage: '/images/icons/calendar-up.gif'
        , buttonImageOnly: true
        , dateFormat: 'dd/mm/yy'
        , clearText: ''
        , firstDay: 1
    });
}

function loadDateTimepicker(element) {
    $(element).datepicker({
        duration: '',
        showTime: true,
        constrainInput: false,
        stepMinutes: 1,
        stepHours: 1,
        altTimeField: '',
        time24h: false,
        firstDay: 1,
        showOn: 'both'
	        , buttonImage: '/images/icons/calendar-up.gif'
	        , buttonImageOnly: true
	        , dateFormat: 'dd/mm/yy'
    });
}

/* xay dưng menu chuc nang, hien thi popup */
jQuery.fn.fmenu = function(tables)
{
    var obj = this;
    var idx = -1;
    if (tables != undefined && tables != "")
    {
        var tbls = tables.split(";");
        for (i=0; i<tbls.length; i++)
        {
            grid_checkbox("table." + tbls[i] + " input[type='checkbox']");
        }
    }
    
    $("span", obj).each(function(index){
        $(this).attr("idx", index);
        
        if ($("." + $(this).attr("box")) != undefined)
        {
            $("div." + $(this).attr("box")).addClass("fmenu-box");
        }
        
        if ($.cookie("fbox") != null && $.cookie("fbox") == $(this).attr("box"))
        {
            $(this).addClass("active");
        }
    });
    
    //alert($.cookie('the_cookie'));
    if ($.cookie("fbox") != null)
    {
        $("div." + $.cookie("fbox")).show();
    }
    
    obj.addClass('fmenu');
    $("<div style='clear:both'></div>").insertAfter(".fmenu ul");
    
    //alert(obj.html());
    obj.find("span").bind('click', function(){
        if ($(this).hasClass("lock") == true)
        {
            return false;
        }
    
        //if ($(this).attr("table") != undefined && $(this).attr("box") != undefined && $("." + $(this).attr("box")).is(':hidden'))
        if ($(this).attr("table") != undefined && $(this).attr("box") != undefined && $(this).hasClass("active") == false)
        {
            var id = "";
            $("table." + $(this).attr("table") + " input[type='checkbox']:not(:first):checked").each(function(){
                id += $(this).attr("id") + ";";
            });
            
            $("input[id$='hid" + $(this).attr("box") + "']").val(id);
            if (id == "")
            {
                alert("Chọn dữ liệu");
                return;
            }
        }
        
        $("span", obj).removeClass("active");
        $(".fmenu-box").hide();
        $("table." + $(this).attr("table") + " input[type='checkbox']").removeClass("lock");
        if (parseInt($(this).attr("idx")) != idx)
        {
            $(this).addClass("active");
            idx = parseInt($(this).attr("idx"));
            $("div." + $(this).attr("box")).show();
            
            $("div." + $(this).attr("box") + " p.title").text($(this).attr("title"));
            //alert($(this).attr("tag"));
            $("input[id$='hidColumn']").val($(this).attr("tag"));
            
            $("table." + $(this).attr("table") + " input[type='checkbox']").addClass("lock");
        }
        else
        {
            idx = -1;
        }
    })
    return this;
}

$(function(){
    loadDatepicker(".date");
    loadDateTimepicker(".datetime");
    $("input:submit").button();

});