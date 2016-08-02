﻿
$(document).ready(function () {


    var MILIMETERS_ERROR = 'La cantidad de milimetros tiene que ser mayor a 0 y menor que 100';
    var MANDATORY_MILMETERS = 'Los milimetros son obligatorios';

    var saveRainBtn = $('#SaveRain');
    var saveIrrigationBtn = $('#SaveIrrigation');
    var savePhenoBtn = $('#savePhenoBtn');
    var irrigationMilimeters = $('#irrigationMilimeters');
    var rainMilimeters = $('#rain');
    var dateOfReferenceBtn = $('#dateOfReferenceBtn');
    var irrigationUnitPheno = $('#IrrigationUnitPheno');
    var specieIdInput = $('#specieId');

    $('#loading').modal({
        keyboard: false,
        backdrop: 'static'
    })

   

    var showLoading = function()
    {
        $('#loading').modal('show');

    }

    var hideLoading = function()
    {
        $('#loading').modal('hide');
    }

    hideLoading();

    rainMilimeters.change(function (event, b) {

        var currentValue = event.target.value;

        if (currentValue)
            saveRainBtn.attr('disabled', false);
        else
            saveRainBtn.attr('disabled', true);


    });

    irrigationMilimeters.change(function (event, b) {

        var currentValue = event.target.value;

        if (currentValue)
            saveIrrigationBtn.attr('disabled', false);
        else
            saveIrrigationBtn.attr('disabled', true);


    });

    rainMilimeters.keyup(function (event, b) {

        var currentValue = event.target.value;

        if (currentValue)
            saveRainBtn.attr('disabled', false);
        else
            saveRainBtn.attr('disabled', true);
        

    });

    irrigationMilimeters.keyup(function (event, b) {

        var currentValue = event.target.value;

        if (currentValue)
            saveIrrigationBtn.attr('disabled', false);
        else
            saveIrrigationBtn.attr('disabled', true);
        

    });

    irrigationUnitPheno.change(function () {

        var selectedIrrigationUnit = irrigationUnitPheno.val();
        var specieId = specieIdInput.val();

        var comboStages = $('#StagePheno');

        debugger;
        $.ajax({
            type: 'GET',
            url: './GetStagesBy?pSpecieId=' + specieId + '&pIrrigationUnitId=' + selectedIrrigationUnit,
            success: function (data) {
               
                debugger;

                //comboStages.append()

            },
            error: function (data) {

                console.log("Error on irrigationUnitPheno.change");
                
            }
        });




    });

    dateOfReferenceBtn.click(function () {

        showLoading();

    });


    savePhenoBtn.click(function () {


        

    });

    saveRainBtn.click(function ()
    {

        if ($('#rain').val())
        {

            var milimeters = parseFloat(rainMilimeters.val());

            var maxValue = parseInt(rainMilimeters.attr('max'));
            var minValue = parseInt(rainMilimeters.attr('min'));


            $('#rainMilimetersError').html('');
            if (milimeters >= minValue && milimeters <= maxValue) {

                var rainDate = moment($('#rainDate :selected').val(), 'MM/DD/YYYY');
                saveRainBtn.attr('disabled', true);
                rainMilimeters.attr('disabled', true);
                showLoading();
                addRain($('#rain').val(),
                                $('#IrrigationUnit :selected').val(),
                                rainDate);
            } else {

                rainMilimeters.addClass('input-red-border');
                $('#rainMilimetersError').html(MILIMETERS_ERROR);
            }

            
        } else {

            saveRainBtn.attr('href', '');
            rainMilimeters.addClass('input-red-border');
            $('#rainMilimetersError').html(MANDATORY_MILMETERS);

        }

        

    });

    saveIrrigationBtn.click(function () {

        

        if ($('#irrigationMilimeters').val())
        {
            var milimeters = parseFloat(irrigationMilimeters.val());

            var maxValue = parseInt(irrigationMilimeters.attr('max'));
            var minValue = parseInt(irrigationMilimeters.attr('min'));

            $('#irrigationMilimetersError').html('');
            if (milimeters >= minValue && milimeters <= maxValue)
            {

                var irrigationDate = moment($('#irrigationDate :selected').val(), 'MM/DD/YYYY');
                $('#irrigationDate').removeClass('.input-red-border');
                saveIrrigationBtn.attr('disabled', true);
                irrigationMilimeters.attr('disabled', true);
                showLoading();
                addIrrigation(irrigationMilimeters.val(),
                                $('#IrrigationUnitIrrigation :selected').val(),
                                irrigationDate);


            }else
            {
                irrigationMilimeters.addClass('input-red-border');
                $('#irrigationMilimetersError').html(MILIMETERS_ERROR);
            }

            
        }
        else
        {
            //saveIrrigationBtn.attr('href', '');
            irrigationMilimeters.addClass('input-red-border');
            $('#irrigationMilimetersError').html(MANDATORY_MILMETERS);
        }

       
    });
   

    var addRain = function (pMilimiters, pIrrigationUnitId, pDate)
    {

        
        var pUrl = './AddRain?pMilimeters=' + pMilimiters +
                '&pIrrigationUnitId=' + pIrrigationUnitId +
                '&pDay=' + pDate.date() +
                '&pMonth=' + (pDate.month() + 1) + 
                '&pYear=' + pDate.year();

        $('#floatingCirclesG').show();
        $.ajax({
            type: 'GET',
            url: pUrl,
            success:function()
            {
                location.href = "./home";
                //location.reload();
                
            },
            error: function(data)
            {
                
                console.log("Error on AddRain");
                //$('#myModal').modal('hide');
            }
        });

    }


    var addIrrigation = function (pMilimiters, pIrrigationUnitId, pDate) {


        var pUrl = './AddIrrigation?pMilimeters=' + pMilimiters +
                '&pIrrigationUnitId=' + pIrrigationUnitId +
                '&pDay=' + pDate.date() +
                '&pMonth=' + (pDate.month() + 1) +
                '&pYear=' + pDate.year();

        
        $.ajax({
            type: 'GET',
            url: pUrl,
            success: function () {

                location.href = "./home";
                //location.reload();

            },
            error: function (data) {

                console.log("Error on AddIrrigation");
                $('#myModal').modal('hide');
            }
        });

    }

    


});