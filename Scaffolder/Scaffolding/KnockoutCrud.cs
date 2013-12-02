using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scaffolder.Scaffolding
{
    public class KnockoutCrud: Scaffolding
    {
        private const char Closed = '}';
        private const char DoubleTic = '"';

        public string Attribute2 { get; set; }
        public string Attribute3 { get; set; }
        public string Attribute4 { get; set; }
        
        public override string ToString()
        {
            return string.Format(@"@{5}
    ViewBag.Title = {7}{0}s' List{7};
{6}



        function {0}ViewModel() {5}

            //Make the self as 'this' reference
            var self = this;
            //Declare observable which will be bind with UI
            self.{0}Id = ko.observable({7}{7});
            self.{2} = ko.observable({7}{7});
            self.{3} = ko.observable({7}{7});
            self.{4} = ko.observable({7}{7});

            var {0} = {5}
                {0}Id: self.{0}Id,
                {2}: self.{2},
                {3}: self.{3},
                {4}: self.{4}
            {6};

            self.{0} = ko.observable();
            self.{0}s = ko.observableArray();   // Contains the list of {0}s

            // Initialize the view-model
            $.ajax({5}
                url: '@Url.Action({7}GetAll{0}s{7}, {7}{0}{7})',
                cache: false,
                type: 'GET',
                contentType: 'application/json; charset=utf-8',
                data: {5}{6},
                success: function (data) {5}
                    self.{0}s(data); //Put the response in ObservableArray
                {6}
            {6});

            // Calculate Total of {3} After Initialization
            self.Total = ko.computed(function () {5}
                var sum = 0;
                var arr = self.{0}s();
                for (var i = 0; i < arr.length; i++) {5}
                    sum += arr[i].{3};
                {6}
                return sum;
            {6});

            //Add New Item
            self.create = function () {5}
                if ({0}.{2}() != {7}{7} && {0}.{3}() != {7}{7} && {0}.{4}() != {7}{7}) {5}
                    $.ajax({5}
                        url: '@Url.Action({7}Add{0}{7}, {7}{0}{7})',
                        cache: false,
                        type: 'POST',
                        contentType: 'application/json; charset=utf-8',
                        data: ko.toJSON({0}),
                        success: function (data) {5}
                            // alert('added');
                            self.{0}s.push(data);
                            self.{2}({7}{7});
                            self.{3}({7}{7});
                            self.{4}({7}{7});
                        {6}
                    {6}).fail(
                         function (xhr, textStatus, err) {5}
                             alert(err);
                         {6});

                {6}
                else {5}
                    alert('Please Enter All the Values !!');
                {6}
            {6}
            // Delete {0} details
            self.delete = function ({0}) {5}
                if (confirm('Are you sure to Delete {7}' + {0}.{2} + '{7} {0} ??')) {5}
                    var {0}Id = {0}.{0}Id;

                    $.ajax({5}
                        url: '@Url.Action({7}Add{0}{7}, {7}{0}{7})',
                        cache: false,
                        type: 'POST',
                        contentType: 'application/json; charset=utf-8',
                        data: ko.toJSON({0}Id),
                        success: function (data) {5}
                            self.{0}s.remove({0});
                            //   alert({7}Record Deleted Successfully{7});
                        {6}
                    {6}).fail(
                     function (xhr, textStatus, err) {5}
                         alert(err);
                     {6});
                {6}
            {6}

            // Edit {0} details

            self.edit = function ({0}) {5}
                self.{0}({0});

            {6}

            // Update {0} details
            self.update = function () {5}
                var {0} = self.{0}();

                $.ajax({5}
                    url: '@Url.Action({7}Edit{0}{7}, {7}{0}{7})',
                    cache: false,
                    type: 'PUT',
                    contentType: 'application/json; charset=utf-8',
                    data: ko.toJSON({0}),
                    success: function (data) {5}
                        self.{0}s.removeAll();
                        self.{0}s(data); //Put the response in ObservableArray
                        self.{0}(null);
                        alert({7}Record Updated Successfully{7});

                    {6}
                {6})
            .fail(
            function (xhr, textStatus, err) {5}
                alert(err);
            {6});
            {6}


            // Reset {0} details
            self.reset = function () {5}
                self.{2}({7}{7});
                self.{3}({7}{7});
                self.{4}({7}{7});
            {6}

            // Cancel {0} details

            self.cancel = function () {5}
                self.{0}(null);

            {6}
        {6}
        var viewModel = new {0}ViewModel();
        ko.applyBindings(viewModel);

    </script>
{6}


<div {1}id={7}body{7}>

    <h2>Knockout CRUD Operations with MVC4</h2>

    <h3>List of {0}s</h3>

    <table {1}id={7}{0}s1{7} data-bind={7}visible: {0}s().length > 0{7}>
        <thead>
            <tr>
                <th>{0}Id</th>
                <th>{2}</th>
                <th>{4}</th>
                <th>{3}</th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody data-bind={7}foreach: {0}s{7}>
            <tr>
                <td data-bind={7}text: {0}Id{7}></td>
                <td data-bind={7}text: {2}{7}></td>
                <td data-bind={7}text: {4}{7}></td>
                <td data-bind={7}text: {3}{7}></td>

                <td>
                    <button data-bind={7}click: $root.edit{7}>Edit</button>
                    <button data-bind={7}click: $root.delete{7}>Delete</button>

                </td>

            </tr>
        </tbody>
        <tfoot>
            <tr>
                <td></td>
                <td></td>
                <td>Total :</td>
                <td data-bind={7}text: formatCurrency($root.Total()){7}></td>
                <td></td>
            </tr>
        </tfoot>
    </table>
    <br />
    <div style={7}border-top: black 2px  #000000; width: 430px; height: 10px{7}>&nbsp;</div>

    <div data-bind={7}if: {0}{7}>
        <div>
            <h2>Update {0}</h2>
        </div>
        <div>
            <label for={7}{0}Id{7} data-bind={7}visible: false{7}>{0}Id</label>
            <label data-bind={7}text: {0}().{0}Id, visible: false{7}></label>

        </div>
        <div>
            <label for={7}{2}{7}>{2}</label>
            <input data-bind={7}value: {0}().{2}{7} type={7}text{7} title={7}{2}{7} />
        </div>

        <div>
            <label for={7}{4}{7}>{4}</label>
            <input data-bind={7}value: {0}().{4}{7} type={7}text{7} title={7}{4}{7} />
        </div>

        <div>
            <label for={7}{3}{7}>{3}</label>
            <input data-bind={7}value: {0}().{3}{7} type={7}text{7} title={7}{3}{7} />

        </div>
        <br />
        <div>
            <button data-bind={7}click: $root.update{7}>Update</button>
            <button data-bind={7}click: $root.cancel{7}>Cancel</button>

        </div>
    </div>

    <div data-bind={7}ifnot: {0}(){7}>
        <div>
            <h2>Add New {0}</h2>
        </div>
        <div>
            <label for={7}name{7}>{2}</label>
            <input data-bind={7}value: $root.{2}{7} type={7}text{7} title={7}{2}{7} />
        </div>

        <div>
            <label for={7}{4}{7}>{4}</label>
            <input data-bind={7}value: $root.{4}{7} type={7}text{7} title={7}{4}{7} />
        </div>

        <div>
            <label for={7}{3}{7}>{3}</label>
            <input data-bind={7}value: $root.{3}{7} type={7}text{7} title={7}{3}{7} />
        </div>
        <br />
        <div>
            <button data-bind={7}click: $root.create{7}>Save</button>
            <button data-bind={7}click: $root.reset{7}>Reset</button>

        </div>
    </div>

</div></pre>


", UpperCaseClassName, LowerCaseClassName, Attribute2, Attribute3, Attribute4, Open,Closed, DoubleTic);
        }
    }
}