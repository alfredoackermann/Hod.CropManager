$(function () {

    var l = abp.localization.getResource('CropManager');

    var service = cropManager.domain.issueType;
    var createModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/IssueType/CreateModal');
    var editModal = new abp.ModalManager(abp.appPath + 'CropManager/Domain/IssueType/EditModal');

    var dataTable = $('#IssueTypeTable').DataTable(abp.libs.datatables.normalizeConfiguration({
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
                                    return l('IssueTypeDeletionConfirmationMessage', data.record.id);
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
                title: l('IssueTypeName'),
                data: "name"
            },
            {
                title: l('IssueTypeDescription'),
                data: "description"
            },
            {
                title: l('IssueTypeSeverity'),
                data: "severity"
            },
        ]
    }));

    createModal.onResult(function () {
        dataTable.ajax.reload();
    });

    editModal.onResult(function () {
        dataTable.ajax.reload();
    });

    $('#NewIssueTypeButton').click(function (e) {
        e.preventDefault();
        createModal.open();
    });
});
