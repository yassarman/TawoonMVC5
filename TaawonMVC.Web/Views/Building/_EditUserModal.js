(function ($) {

    var _BuildingService = abp.services.app.buildings;
    var _$modal = $('#UserEditModal');
    var _$form = $('form[name=UserEditForm]');

    function save() {

        if (!_$form.valid()) {
            return;
        }

        var _buildingUpdate = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js
        _buildingUpdate.Id = document.getElementById('Id').value;     
        _buildingUpdate.numOfBuildingUnits = document.getElementById('NumOfBuildingUnits').value;
        _buildingUpdate.numOfFloors = document.getElementById('NumOfFloors').value;
        _buildingUpdate.streetName = document.getElementById('StreetName').value;
        _buildingUpdate.buildingNo = document.getElementById('BuildingNo').value;
        _buildingUpdate.neighborhoodID = document.getElementById('NeighborhoodID').value;
        _buildingUpdate.buildingTypeID = document.getElementById('BuildingTypeID').value;
        _buildingUpdate.GISMAP = document.getElementById('GISMAP1').value;
        _buildingUpdate.houshProperty = document.getElementById('HoushProperty').value;
        _buildingUpdate.houshName = document.getElementById('HoushName').value;
        _buildingUpdate.X = document.getElementById('Xx').value;
        _buildingUpdate.Y = document.getElementById('Yy').value;


        //user.roleNames = [];
        //var _$roleCheckboxes = $("input[name='role']:checked");
        //if (_$roleCheckboxes) {
        //    for (var roleIndex = 0; roleIndex < _$roleCheckboxes.length; roleIndex++) {
        //        var _$roleCheckbox = $(_$roleCheckboxes[roleIndex]);
        //        user.roleNames.push(_$roleCheckbox.attr('data-role-name'));
        //    }
        //}

        abp.ui.setBusy(_$form);
        _BuildingService.update(_buildingUpdate).done(function () {
            _$modal.modal('hide');
            location.reload(true); //reload page to see edited user!
        }).always(function () {
            abp.ui.clearBusy(_$modal);
        });
    }

    //Handle save button click
    _$form.closest('div.modal-content').find(".save-button").click(function (e) {
        e.preventDefault();
        save();
    });

    //Handle enter key
    _$form.find('input').on('keypress', function (e) {
        if (e.which === 13) {
            e.preventDefault();
            save();
        }
    });

    $.AdminBSB.input.activate(_$form);

    _$modal.on('shown.bs.modal', function () {
        _$form.find('input[type=text]:first').focus();
    });
})(jQuery);