// AlmostDone: Place optional API call here to demonstrate optional path.
// ToDo: clean up JS api call display.

// Api url.
const apiUrl = "https://frontiercodingtests.azurewebsites.net/api/accounts/getall";

// Define an async Get().
function getAllAccounts(url) {
    // Inst new XHR Object.
    //const apiResponse = await fetch(url);
    //const xhr = new XMLHttpRequest();

    // Store data in json format.
    //const data = await apiResponse.json();

    //xhr.open("GET", apiUrl, true);

    //if (apiResponse) {
    //    console.log("Nothing here");
    //} else {
    //    console.log(data);
    //}

    $.ajax({
        type: "GET",
        url: apiUrl,
        dataType: "json",
        success: function(result, status, xhr) {
            var dasGrid = "";
            console.log(result);
            
            for (let user in result) {
                console.log(user);
                if (result[user]["AccountStatusId"] === 0) {
                    dasGrid += `
    <div class="account-column active-account-column">
        <div class="account-container-title active-account-container-title">
            <h3>Active</h3>
        </div>
        <div class="account-container active-account">
            <ul class="account-data-list">
                
            <li>
                <label>Name:</label>${result[user]["LastName"]}, ${result[user]["FirstName"]}
            </li>
            <li>
                <label>Email:</label>${result[user]["Email"]}
            </li>
            <li>
              <label>Phone Number:</label>${result[user]["PhoneNumber"]}
            </li>
            <li>
              <label>Amount Due:</label>${result[user]["AmountDue"]}
            </li>
            <li>
                <label>Due Date:</label>${result[user]["PaymentDueDate"]}
            </li>`;
                }
                dasGrid += `</ul>
        </div>
    </div>`;
                if (result[user]["AccountStatusId"] === 1) {
                    dasGrid += `
    <div class="account-column overdue-account-column">
        <div class="account-container-title overdue-account-container-title">
            <h3>Overdue</h3>
        </div>
        <div class="account-container overdue-account">
            <ul class="account-data-list">
                
            <li>
                <label>Name:</label>${result[user]["LastName"]}, ${result[user]["FirstName"]}
            </li>
            <li>
                <label>Email:</label>${result[user]["Email"]}
            </li>
            <li>
              <label>Phone Number:</label>${result[user]["PhoneNumber"]}
            </li>
            <li>
              <label>Amount Due:</label>${result[user]["AmountDue"]}
            </li>
            <li>
                <label>Due Date:</label>${result[user]["PaymentDueDate"]}
            </li>`;

                }

                dasGrid += `</ul>
        </div>
    </div>`;
                if (result[user]["AccountStatusId"] === 2) {
                    dasGrid += ` 
    <div class="account-column inactive-account-column">
        <div class="account-container-title inactive-account-container-title">
            <h3>Inactive</h3>
        </div>
        <div class="account-container inactive-account">
            <ul class="account-data-list">
                
            <li>
                <label>Name:</label>${result[user]["LastName"]}, ${result[user]["FirstName"]}
            </li>
            <li>
                <label>Email:</label>${result[user]["Email"]}
            </li>
            <li>
              <label>Phone Number:</label>${result[user]["PhoneNumber"]}
            </li>
            <li>
              <label>Amount Due:</label>${result[user]["AmountDue"]}
            </li>
            <li>
                <label>Due Date:</label>${result[user]["PaymentDueDate"]}
            </li>`;
                }
                dasGrid += `</ul>       </div>    </div>`;

            }

            $("#account-grid").html(dasGrid);
        },
        error: function(xhr, status, error) { alert("Result: " + status + " " + error + " " + xhr.status + " " + xhr.statusText); }
    });
}

$(document).ready(function() {
    // Call the Api Method.
    // Uncomment this to call JS api call.
    //getAllAccounts(apiUrl);
});