(function () {
    $(function () {

        var _BuildingService = abp.services.app.buildings;
       // var _NeighborhoodService = abp.services.app.neighborhood
        var _$modal = $('#UserCreateModal');
        var _$form = _$modal.find('form');

        _$form.validate({
            rules: {
                Password: "required",
                ConfirmPassword: {
                    equalTo: "#Password"
                }
            }
        });

        $('#RefreshButton').click(function () {
            refreshUserList();
        });

        $('.delete-user').click(function () {
            var userId = $(this).attr("data-BuildingType-id");
            var userName = $(this).attr('data-BuildingType-name');

            deleteUser(userId, userName);
        });

        $('.edit-user').click(function (e) {
            var userId = $(this).attr("data-BuildingType-id");

            e.preventDefault();
            $.ajax({
                url: abp.appPath + 'Building/EditBuildingModal?userId=' + userId,
                type: 'POST',
                contentType: 'application/html',
                success: function (content) {
                    $('#UserEditModal div.modal-content').html(content);
                },
                error: function (e) { }
            });
        });

        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$form.valid()) {
                return;
            }

            var _building = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js
            _building.numOfBuildingUnits = document.getElementById('numOfBuildingUnits').value;
            _building.numOfFloors = document.getElementById('numOfFloors').value;
            _building.streetName = document.getElementById('streetName').value;
            _building.buildingNo = document.getElementById('buildingNo').value;
            _building.IsInHoush = document.getElementById('IsInHoush').value;
            _building.houshName = document.getElementById('houshName').value;
            _building.neighborhoodID = document.getElementById('neighborhoodID').value;
            _building.buildingTypeID = document.getElementById('buildingTypeID').value;
            _building.buildingUsesID = document.getElementById('buildingUsesID').value;
            _building.GISMAP = document.getElementById('GISMAP').value;
            _building.houshProperty = document.getElementById('houshProperty').value;
            _building.X = document.getElementById('X').value;
            _building.Y = document.getElementById('Y').value;
           

            //user.roleNames = [];
            //var _$roleCheckboxes = $("input[name='role']:checked");
            //if (_$roleCheckboxes) {
            //    for (var roleIndex = 0; roleIndex < _$roleCheckboxes.length; roleIndex++) {
            //        var _$roleCheckbox = $(_$roleCheckboxes[roleIndex]);
            //        user.roleNames.push(_$roleCheckbox.attr('data-role-name'));
            //    }
            //}

            abp.ui.setBusy(_$modal);
            _BuildingService.create(_building).done(function () {
                _$modal.modal('hide');
                location.reload(true); //reload page to see new user!
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });

        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();
        });

        function refreshUserList() {
            location.reload(true); //reload page to see new user!
        }

        function deleteUser(userId, userName) {
            abp.message.confirm(
                "Delete Building '" + userName + "'?",
                function (isConfirmed) {
                    if (isConfirmed) {
                        _BuildingService.delete({
                            id: userId
                        }).done(function () {
                            refreshUserList();
                        });
                    }
                }
            );
        }
    });
})();