$(function () {

    var l = abp.localization.getResource('CropManager');

    var service = cropManager.domain.crop;
    var createModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/Crop/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/Crop/EditModal');

    var dataTable = $('#CropTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                    return l('CropDeletionConfirmationMessage', data.record.id);
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
                title: l('CropCropType'),
                data: "cropType"
            },
            {
                title: l('CropCropTypeId'),
                data: "cropTypeId"
            },
            {
                title: l('CropField'),
                data: "field"
            },
            {
                title: l('CropFieldId'),
                data: "fieldId"
            },
            {
                title: l('CropSize'),
                data: "size"
            },
            {
                title: l('CropPlantingMethod'),
                data: "plantingMethod"
            },
            {
                title: l('CropGrowthStages'),
                data: "growthStages"
            },
            {
                title: l('CropIrrigationSchedules'),
                data: "irrigationSchedules"
            },
            {
                title: l('CropFertilizationSchedules'),
                data: "fertilizationSchedules"
            },
            {
                title: l('CropPesticideSchedules'),
                data: "pesticideSchedules"
            },
            {
                title: l('CropHarvests'),
                data: "harvests"
            },
            {
                title: l('CropCropIssues'),
                data: "cropIssues"
            },
            {
                title: l('CropPlantingDate'),
                data: "plantingDate"
            },
            {
                title: l('CropHarvestDate'),
                data: "harvestDate"
            },
            {
                title: l('CropCreationTime'),
                data: "creationTime"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewCropButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
