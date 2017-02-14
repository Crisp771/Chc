var ServiceUI = {
    onEWCAdditionalData: function (e) {
        return {
            text: $("#EWCode").val()
        };
    },
    onStartDateChange: function (e) {
        $("#ScheduleDay").data("kendoDropDownList").select(kendo.parseDate($(e.sender.element).val()).getDay());
        //["Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday"][kendo.parseDate($(e.sender.element).val()).getDay()]
    },
    onEdit: function (e) {
        //var kendoWindow = e.container.data("kendoWindow");
        $("#ScheduleDay").data("kendoDropDownList").select(kendo.parseDate($("#StartDate").val()).getDay());
        //if (e.model.isNew()) {
        //    //set options using the setOptions method
        //    kendoWindow.setOptions({
        //        title: "New record!"
        //    });
        //} else {
        //    //set options using the setOptions method
        //    kendoWindow.setOptions({
        //        title: "Old record!"
        //    });
        //}
    }
};