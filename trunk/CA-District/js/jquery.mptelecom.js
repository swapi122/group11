$(function(){
    // -------------
    layout_table_grid();
    layout_table_freeze();
    
    loadDatepicker(".date");
    loadDateTimepicker(".datetime");
    
    $(".numeric-int").numeric();
    
    
    t();
    
    function t()
    {
        $("div.button").each(function(i){
            var t = $("input", $(this)).length;
            if (t == 0)
                $(this).hide();
        });
        
        $("span.button").each(function(i){
            var t = $("input", $(this)).length;
            if (t == 0)
                $(this).hide();
        });
    }
    $("table.grid tr:not(:first)").hover(
        function(){
            if ($(this).attr("hover") != "false")
            {
                $(this).addClass("highlight");
            }
        },
        function(){
            if ($(this).attr("hover") != "false")
            {
                $(this).removeClass("highlight");
            }
        }

    );
    
    $("table.grid-freeze tbody tr:not(:first)").hover(
        function(){
            //$(this).addClass("highlight");
            $(".idx" + $(this).attr("idx")).addClass("highlight");
        },
        function(){
            //$(this).removeClass("highlight");
            $(".idx" + $(this).attr("idx")).removeClass("highlight");
        }
    );
    
    $("table.hover tr:not(:first)").hover(
        function(){
            $(this).addClass("highlight");
            
        },
        function(){
            $(this).removeClass("highlight");
        }

    );
    
    $("table.alter tr:not(:first) tr:odd").addClass("odd");
    $("table.alter tr:even").addClass("even");
    
    $("table.grid-freeze tbody tr:not(:first) tr:odd").addClass("odd");
    $("table.grid-freeze tbody tr:even").addClass("even");
     
    function layout_table_grid()
    {
    
        $("table.grid th").each(function(i){
            var tt = $(this).html();
            tt = $.trim(tt);
            $(this).html("<div><div><h2>" + tt + "</h2></div></div>").width($(this).width());
            //alert($(this).width());
            
        });
        //alert($("table.grid th").height());
        $("table.grid th h2").height($("table.grid th").height()-19);
    }
    
    function layout_table_freeze()
    {
        if ($("#freeze").length > 0)
        {
            var w = 0;
            if ($("#content-1col").length > 0)
                w = $("#content-1col").width();
            else
                w = $("td.container").width();
            var fw = $(".freeze-col").width();
            var gwidth = 0;
            $("div.freeze table.grid-freeze tr:first th").each(function(){
                if (isNaN(parseInt($(this).attr("width"))))
                {
                    gwidth += $(this).width();
                    //alert("1");
                }
                else
                {
                    gwidth += parseInt($(this).attr("width"));
                    //alert(parseInt($(this).attr("width")));
                }
                //alert($(this).attr("width"));
                //gwidth += $(this).width();
                
            });
            //alert(gwidth);
            if (gwidth > (w - fw - 29))
                $("div.freeze table.grid-freeze").width(gwidth);
            
            $(".freeze").width(w - fw - 29);
            
            var h = 0;
            var h1 = 0;
            /* --- fix chieu cao header --- */
            if ($("div.freeze-col table.grid-freeze thead").height() > $("div.freeze table.grid-freeze thead").height())
            {
                $("div.freeze table.grid-freeze thead").height($("div.freeze-col table.grid-freeze thead").height());
                h1 = $("div.freeze-col table.grid-freeze thead").height();
            }
            else
            {
                $("div.freeze-col table.grid-freeze thead").height($("div.freeze table.grid-freeze thead").height());
                h1 = $("div.freeze table.grid-freeze thead").height();
            }
            
            $("div.freeze table.grid-freeze tbody tr").each(function(i){
                if ($("div.freeze-col table.grid-freeze tbody tr.idx" + i).height() > $("div.freeze table.grid-freeze tbody tr.idx" + i).height())
                {
                    $("div.freeze table.grid-freeze tbody tr.idx" + i).height($("div.freeze-col table.grid-freeze tbody tr.idx" + i).height());
                }
                else
                {
                    $("div.freeze-col table.grid-freeze tbody tr.idx" + i).height($("div.freeze table.grid-freeze tbody tr.idx" + i).height());
                }
            });
                
            /* --- fix chieu cao cua body --- */
            //alert($("#freeze").position().top);
            //alert($(window).height());
            /*
            if ($("#freeze").height() + $("#freeze").position().top > $(window).height())
            {
                h = $(window).height() - $("#freeze").position().top - 20;
                //alert(h);
                $("table.grid-freeze tbody").height(h);
                $("table.grid-freeze tbody").css("overflow", "hidden");
                
                $(".freeze").width(w - fw - 29 - $(".freeze-slider").width() - 5);
                
                $(".freeze-slider").height(h);
                $(".freeze-slider").show();
                $(".freeze-slider").css("margin-top", h1);
                
                var row = $("div.freeze table.grid-freeze tbody tr").length;
                
                row = row - Math.round(h / $("table.grid-freeze tbody tr").height()) + 2;
                
                $(".freeze-slider").slider({
			        orientation: "vertical",
			        range: "min",
			        max: row,
			        min: 0,
			        value: row,
			        slide: function(event, ui) {
			            //$("#sd").text(ui.value);
			            if (ui.value >= 0)
			            {
			                var val = row - ui.value;
				            $("#sd").text(ui.value);
    				        /*
				            $("div.freeze table.grid-freeze tbody tr").show();
				            $("div.freeze table.grid-freeze tbody tr").each(function(i){
				                if (i < val)
				                {
				                    $(this).hide();
    				                
				                }
				            });
    				        
    				        $("div.freeze table.grid-freeze tbody tr").show();
				            $("div.freeze-col table.grid-freeze tbody tr").show();
				            
				            if (val > 1)
				            {
				                $("div.freeze-col table.grid-freeze tbody tr:lt(" + (val - 1) + ")").hide();
				                $("div.freeze table.grid-freeze tbody tr:lt(" + (val - 1) + ")").hide();
				            }
				            
				            /*
				            $("div.freeze-col table.grid-freeze tbody tr").each(function(i){
				                if (i < val)
				                {
				                
				                    //$(this).hide();
    				                //$("table.grid-freeze tbody tr.idx" + i).hide();
				                }
				            });
				            
				        }
			        }
		        });
            }
            */
            //alert($("div.freeze table.grid-freeze tr:not(:first)").length);
        }
    }
});

function loadDatepicker(element)
{
    $(element).datepicker({
        showOn: 'both'
        , buttonImage: '/images/button/calendar-up.gif'
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
        showOn: 'both'
	        , buttonImage: '/images/button/calendar-up.gif'
	        , buttonImageOnly: true
	        , dateFormat: 'dd/mm/yy'
    });
}

function loadTimepicker(element) {
    $(element).timeEntry({show24Hours: true, showSeconds: true});
}

function grid_checkbox(element)
{
    $(element).bind("click", function(){
        if ($(this).hasClass("lock"))
            return false;
            
        var id = $(this).attr("id");
        var checked;
        
        if (id == "")
        {
            checked = $(this).is(':checked');
            $(element).attr('checked', checked);
        }
        else
        {
            
        }
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