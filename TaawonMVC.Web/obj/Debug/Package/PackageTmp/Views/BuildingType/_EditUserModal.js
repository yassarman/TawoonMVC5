(function ($) {

    var _buildingTypeService = abp.services.app.buildingType;
    var _$modal = $('#UserEditModal');
    var _$form = $('form[name=UserEditForm]');

    function save() {

        if (!_$form.valid()) {
            return;
        }

        var _buildingType = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js
        _buildingType.Id = document.getElementById('Id').value;
        _buildingType.AName = document.getElementById('username').value;
        _buildingType.EName = document.getElementById('name').value;
        //user.roleNames = [];
        //var _$roleCheckboxes = $("input[name='role']:checked");
        //if (_$roleCheckboxes) {
        //    for (var roleIndex = 0; roleIndex < _$roleCheckboxes.length; roleIndex++) {
        //        var _$roleCheckbox = $(_$roleCheckboxes[roleIndex]);
        //        user.roleNames.push(_$roleCheckbox.attr('data-role-name'));
        //    }
        //}

        abp.ui.setBusy(_$form);
        _buildingTypeService.update(_buildingType).done(function () {
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