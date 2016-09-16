var startDate;
var endDate;

$(document).ready(function () {
		// Date Range Picker

    $('#daterangepicker1').daterangepicker({
        "locale": {
            "format": "DD.MM.YYYY",
            "separator": " - ",
            "applyLabel": "Kaydet",
            "cancelLabel": "�ptal",
            "fromLabel": "D�zenlenme",
            "toLabel": "Son �deme",
            "customRangeLabel": "Custom",
            "daysOfWeek": [
                "Pa",
                "Pzt",
                "Sa",
                "�a",
                "Pe",
                "Cu",
                "Cmt"
            ],
            "monthNames": [
                "Ocak",
                "�ubat",
                "Mart",
                "Nisan",
                "May�s",
                "Haziran",
                "Temmuz",
                "A�ustos",
                "Eyl�l",
                "Ekim",
                "Kas�m",
                "Aral�k"
            ],
            "firstDay": 1
        }
    },

    function(start, end) {
        $('#reportrange span').html(start.format('D MMMM YYYY') + ' - ' + end.format('D MMMM YYYY'));
        startDate = start;
        endDate = end;    

    }
    );

    $('#reportrange span').html(moment().subtract('days', 29).format('D MMMM YYYY') + ' - ' + moment().format('D MMMM YYYY'));

    $('#saveBtn').click(function () {
        console.log(startDate.format('D MMMM YYYY') + ' - ' + endDate.format('D MMMM YYYY'));
    });


		$('#daterangepicker2').daterangepicker({
		ranges: {
			'Bug�n': [moment(), moment()],
			'D�n': [moment().subtract('g�n', 1), moment().subtract('g�n', 1)],
			'Son 7 G�n': [moment().subtract('g�n', 6), moment()],
			'Son 30 G�n': [moment().subtract('g�n', 29), moment()],
			'Bu Ay': [moment().startOf('ay'), moment().endOf('ay')],
			'Ge�en Ay': [moment().subtract('ay', 1).startOf('ay'), moment().subtract('ay', 1).endOf('ay')]
		},
		opens: 'kalan',
		startDate: moment().subtract('g�n', 29),
		endDate: moment()
		},
		function(start, end) {
			$('#daterangepicker2 span').html(start.format('MMMM D, YYYY') + ' - ' + end.format('MMMM D, YYYY'));
		});

		$('#daterangepicker3').daterangepicker({ timePicker: true, timePickerIncrement: 30, format: 'MM/DD/YYYY h:mm A' });


		//Color Picker
		$('.cpicker').colorpicker();

		//Eternicode Datepicker
		$("#datepicker").datepicker({todayHighlight: true});
		$('#datepicker-pastdisabled').datepicker({
			todayHighlight: true,
	    	startDate: "-3d",
	    	endDate: "+3d"
		});
		$('#datepicker-startview').datepicker({
			todayHighlight: true,
	    	startView: 1
		});
		$('#datepicker-inline').datepicker({todayHighlight: true});
		$('#datepicker-range').datepicker({todayHighlight: true});

		//m3wolf Time Picker
		$('#timepicker1').timepicker();
		$('#timepicker2').timepicker({
			minuteStep: 5,
	        showInputs: false,
	        disableFocus: true
		});
		$('#timepicker3').timepicker({
	        template: false,
	        showInputs: false,
	        minuteStep: 5
	    });


	    //Clockface
		$('#t1').clockface();  
		$('#t2').clockface({
	        format: 'HH:mm',
	        trigger: 'manual'
	    });
	    $('#toggle-btn').click(function(e){   
	        e.stopPropagation();
	        $('#t2').clockface('toggle');
	    });

	    $('#t3').clockface({
        	format: 'H:mm'
    	}).clockface('show', '14:30')


    	//malot.fr Date Time Picker

		$('#dtp-1, #dtp-2, #dtp-4').datetimepicker({format: 'yyyy-mm-dd hh:ii'});

	    $("#dtp-3").datetimepicker({
	        format: "dd MM yyyy - hh:ii",
	        showMeridian: true
	    });

	    $('#dtp-5').datetimepicker({  // Date
	    	format: "dd MM yyyy",
	    	weekStart: 1,
        	todayBtn:  1,
			autoclose: 1,
			todayHighlight: 1,
			startView: 2,
			minView: 2,
			forceParse: 0
	    });

		$('#dtp-6').datetimepicker({ // Time
			format: "hh:ii",
        	weekStart: 1,
        	todayBtn:  1,
			autoclose: 1,
			todayHighlight: 1,
			startView: 1,
			minView: 0,
			maxView: 1,
			forceParse: 0
	    });

		$('.input-group-addon .fa-th').removeClass('fa fa-th').addClass('ti ti-view-grid');
		$('.input-group-addon .fa-close').removeClass('fa fa-close').addClass('ti ti-close');
		$('.input-group-addon .fa-clock-o').removeClass('fa fa-clock-o').addClass('ti ti-time');
		$('.input-group-addon .fa-calendar').removeClass('fa fa-calendar').addClass('ti ti-calendar');

});