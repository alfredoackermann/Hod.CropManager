$(function () {

    var l = abp.localization.getResource('CropManager');

    var service = cropManager.domain.cropType;
    var createModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/CropType/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/CropType/EditModal');

    var dataTable = $('#CropTypeTable').DataTable(abp.libs.datatables.normalizeConfiguration({
        processing: true,
        serverSide: true,
        paging: true,
        searching: false,
        autoWidth: false,
        scrollCollapse: true,
        order: [[0, "asc"]],
        ajax: abp.libs.datatables.createAjax(service.getList),
        columnDefs: [
            {
                rowAction: {
                    items:
                        [
                            {
                                text: l('Edit'),
                                action: function (data) {
                                    editModal.open({ id: data.record.id });
                                }
                            },
                            {
                                text: l('Delete'),
                                confirmMessage: function (data) {
                                    return l('CropTypeDeletionConfirmationMessage', data.record.id);
                                },
                                action: function (data) {
                                    service.delete(data.record.id)
                                        .then(function () {
                                            abp.notify.info(l('SuccessfullyDeleted'));
                                            dataTable.ajax.reload();
                                        });
                                }
                            }
                        ]
                }
            },
            {
                title: l('CropTypeName'),
                data: "name"
            },
            {
                title: l('CropTypeDescription'),
                data: "description"
            },
            {
                title: l('CropTypeGrowthDuration'),
                data: "growthDuration"
            },
            {
                title: l('CropTypeWaterRequirements'),
                data: "waterRequirements"
            },
            {
                title: l('CropTypeSoilRequirements'),
                data: "soilRequirements"
            },
            {
                title: l('CropTypeSunRequirements'),
                data: "sunRequirements"
            },
            {
                title: l('CropTypeTemperatureRange'),
                data: "temperatureRange"
            },
            {
                title: l('CropTypeHumidityRange'),
                data: "humidityRange"
            },
            {
                title: l('CropTypeNutrientRequirements'),
                data: "nutrientRequirements"
            },
            {
                title: l('CropTypePestsAndDisease'),
                data: "pestsAndDisease"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewCropTypeButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
