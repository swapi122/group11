
$(function()
{
    var hideDelay = 0;  
    var currentID;
    var hideTimer = null;

    // One instance that's reused to show info for the current person
    var container = $('<div id="personPopupContainer">'
                    + '<table width="350px" border="0" cellspacing="0" cellpadding="0" align="center" class="personPopupPopup">'
                    + '<tr>'
                    + '   <td class="corner topLeft"></td>'
                    + '   <td class="top"></td>'
                    + '   <td class="corner topRight"></td>'
                    + '</tr>'
                    + '<tr>'
                    + '   <td class="left">&nbsp;</td>'
                    + '   <td><div id="personPopupContent"></div></td>'
                    + '   <td class="right">&nbsp;</td>'
                    + '</tr>'
                    + '<tr>'
                    + '   <td class="corner bottomLeft">&nbsp;</td>'
                    + '   <td class="bottom">&nbsp;</td>'
                    + '   <td class="corner bottomRight"></td>'
                    + '</tr>'
                    + '</table>'
                    + '</div>');

    $('body').append(container);

    $('.viewPopup').live('mouseover', function()
    {  
        // format of 'rel' tag: pageid,personguid
        var settings = $(this).attr('rel').split(',');
        var pageID = settings[0];
        currentID = settings[1];
       
        // If no guid in url rel tag, don't popup blank
        if (currentID == '')
            return;
        var page = "";         
        switch(pageID){
            case "customer":
                page = "/CRM/Customer/Webservices/GetViewCustomer.aspx";
                break;
            case "contact":
                page = "/CRM/Customer/Webservices/GetViewContact.aspx";
                break;
            case "note":
                page = "/CRM/Customer/Webservices/GetViewNote.aspx";
                break;
            case "project":
                page = "/CRM/Customer/Webservices/GetViewProject.aspx";
                break;
            case "appo":
                page = "/CRM/Customer/Webservices/GetViewAppo.aspx";
                break;
            case "member":
                page = "/Member/Webservice/GetViewMember.aspx";
                break;
            case "task":
                page = "/CRM/Task/Webservices/ViewTask.aspx";
                break;
            case "file":
                page = "/CRM/Task/Webservices/ViewFile.aspx";
                break;
            case "pnote":
                page = "/CRM/Customer/Webservices/GetViewPrjNote.aspx";
                break;
            case "branch":
                page = "/Admin/Hurman/Webservices/ViewBranch.aspx";
                break;
            case "depart":
                page = "/Admin/Hurman/Webservices/ViewDepart.aspx";
                break;
            case "projecttask":            
                page = "/Projects/GetAjaxInfo/ProjectViewTask.aspx";
                break;            
            case "projectPortal":
                page = "/Projects/GetAjaxInfo/ProjectViewTask.aspx";
                break;
            default:
                return;
                break;
        }
        if (hideTimer)
            clearTimeout(hideTimer);

        var pos = $(this).offset();
        var width = $(this).width();
        container.css({
            left: (pos.left + width) + 'px',
            top: pos.top - 5 + 'px'
        });

        $('#personPopupContent').html('<img src="/images/ajax-loader.gif" />');

        //alert(page);
        $.ajax({
            type: 'GET',
            url: page,
            data: 'id=' + currentID,
            success: function(data)
            {
                //var text = $(data).find('.personPopupResult').html();
                $('#personPopupContent').html(data);
            }
        });
        
        container.css('display', 'block');
    });

    $('.viewPopup').live('mouseout', function()
    {
        if (hideTimer)
            clearTimeout(hideTimer);
        hideTimer = setTimeout(function()
        {
            container.css('display', 'none');
        }, hideDelay);
    });

    // Allow mouse over of details without hiding details
    $('#personPopupContainer').mouseover(function()
    {
        if (hideTimer)
        clearTimeout(hideTimer);
    });

    // Hide after mouseout
    $('#personPopupContainer').mouseout(function()
    {
        if (hideTimer)
            clearTimeout(hideTimer);
        hideTimer = setTimeout(function()
        {
            container.css('display', 'none');
        }, hideDelay);
    });
});