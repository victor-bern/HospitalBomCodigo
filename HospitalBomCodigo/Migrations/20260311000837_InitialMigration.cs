using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HospitalBomCodigo.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Status = table.Column<int>(type: "INTEGER", nullable: false),
                    NotificationSent = table.Column<bool>(type: "INTEGER", nullable: false),
                    ResultReleasedAt = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "Description", "NotificationSent", "ResultReleasedAt", "Status", "Type" },
                values: new object[,]
                {
                    { new Guid("01b1e924-678c-407b-ac43-71495e16ee5a"), "Sapiente ipsa reprehenderit eius ad saepe quisquam reiciendis sapiente praesentium.", false, null, 1, "Raio-X" },
                    { new Guid("0323a1a5-7c7b-4bde-a396-839eb62bcb5f"), "Autem magni eum.", false, null, 1, "Exame de Sangue" },
                    { new Guid("0a0a55b3-0962-4c4e-bd34-255908746cbf"), "Quas minus eius mollitia voluptates voluptas.", false, null, 1, "MRI" },
                    { new Guid("0a2842bb-fef6-4f47-bc9f-3c81c3b7ef98"), "Ut in assumenda praesentium vero iure facilis atque.", false, null, 1, "MRI" },
                    { new Guid("0df5df6a-0f90-417e-831f-b21396a78441"), "Voluptatem ea enim voluptas voluptas.", false, null, 1, "Exame de Sangue" },
                    { new Guid("0f7adb6a-656d-4ef1-a600-5d87e79dc251"), "Et placeat illum perferendis minima.", false, null, 1, "MRI" },
                    { new Guid("128d04f7-3f3e-4b2a-b4ca-d18901f319bc"), "Esse aperiam aliquid ut inventore et sit voluptatem dolorum.", false, null, 1, "MRI" },
                    { new Guid("16e7966f-4f26-465b-b371-2125ce780292"), "Voluptas officiis doloremque sint aut sint neque blanditiis assumenda et.", false, null, 1, "Exame de Sangue" },
                    { new Guid("178ac076-d21f-4cb1-b8d3-ad8392dae050"), "Culpa molestiae cumque beatae sed temporibus.", false, null, 1, "Exame de Sangue" },
                    { new Guid("18deca53-6ae6-4112-8962-a9c5f5884905"), "Sunt reprehenderit exercitationem labore rerum hic.", false, null, 1, "Exame de Sangue" },
                    { new Guid("1f187d89-2724-4760-bc33-e050a2e2a6d1"), "Eveniet id voluptas cumque aut ab doloribus nobis harum.", false, null, 1, "Raio-X" },
                    { new Guid("225ba9da-e5f1-4025-8a0f-1beb372d1dbd"), "Consectetur dolores eos quo qui.", false, null, 1, "MRI" },
                    { new Guid("23935905-225e-4722-a883-85511913133f"), "Aspernatur omnis omnis nemo autem quis recusandae.", false, null, 1, "Raio-X" },
                    { new Guid("242f2e99-e788-4e30-9568-308451935d43"), "Nam rerum quod cumque vel repellendus minima.", false, null, 1, "Exame de Sangue" },
                    { new Guid("247559df-5e6e-4071-99ab-e806b2f9460b"), "Eius praesentium quia et dicta ut sint.", false, null, 1, "Raio-X" },
                    { new Guid("282d7bd0-43d2-447c-9673-ac7b112c2d7f"), "Soluta et quia excepturi sunt omnis officia dicta.", false, null, 1, "Exame de Sangue" },
                    { new Guid("3217c91a-a0f7-4fee-94b5-95cb9325c025"), "Molestiae id ipsa placeat iusto.", false, null, 1, "MRI" },
                    { new Guid("325ef812-d94a-4c4a-b314-62cbf73b15b0"), "Deleniti aut quidem et sunt est enim fugit et.", false, null, 1, "MRI" },
                    { new Guid("32caae57-f83b-45de-b224-cae6154ea0f7"), "Quis eligendi omnis exercitationem praesentium doloremque iure expedita asperiores alias.", false, null, 1, "Exame de Sangue" },
                    { new Guid("38c8d460-8116-4c39-b967-86a155dbde19"), "Dolorem et id nobis.", false, null, 1, "Raio-X" },
                    { new Guid("39c49f28-60c5-4de9-ae0f-d1b11399dcba"), "Est nihil ea occaecati ad amet enim.", false, null, 1, "MRI" },
                    { new Guid("3bf49058-5ad4-476a-a0f4-924023c180bc"), "Velit nam recusandae.", false, null, 1, "Raio-X" },
                    { new Guid("3f9743e7-96c1-42de-a6ef-093f7aa1bab7"), "Voluptatem esse quo.", false, null, 1, "Raio-X" },
                    { new Guid("41479db9-4aff-4adf-9413-6d8769b02541"), "Aut quia ab.", false, null, 1, "Raio-X" },
                    { new Guid("47f06cce-9084-4478-bda9-3e82a1609c06"), "Placeat id facilis omnis.", false, null, 1, "Exame de Sangue" },
                    { new Guid("4dfa3e81-96f4-43ed-be93-f008a722f57d"), "Rerum velit facere veniam iusto omnis hic similique optio.", false, null, 1, "Raio-X" },
                    { new Guid("4e00f057-0897-407c-b978-47e8c39acb15"), "Maxime sit suscipit dignissimos dolorum cupiditate dolor omnis reiciendis eos.", false, null, 1, "Exame de Sangue" },
                    { new Guid("501eb905-a3dc-4981-8f0d-491811b7b9f4"), "Autem eligendi natus non.", false, null, 1, "MRI" },
                    { new Guid("50ea1c0b-43ac-46ce-9024-c6de0327db25"), "Modi dolor enim reiciendis nesciunt maiores.", false, null, 1, "Raio-X" },
                    { new Guid("52ce2a20-a4d1-4c28-a5bc-e0c10411de32"), "Velit est excepturi unde asperiores.", false, null, 1, "MRI" },
                    { new Guid("5467937f-6ff7-4ccf-9b26-a9fc8c7acaa3"), "Praesentium nam voluptatem perspiciatis non.", false, null, 1, "Raio-X" },
                    { new Guid("621ee65d-92f1-40e6-b8ec-d434fe84dee9"), "Mollitia sit repudiandae sit hic modi voluptatum repudiandae fugiat.", false, null, 1, "Exame de Sangue" },
                    { new Guid("63620ed5-69cb-4f74-b024-6de5478182e8"), "Quia voluptatum adipisci est est qui et.", false, null, 1, "MRI" },
                    { new Guid("66860acb-d369-4465-a935-94b9f63ad7f4"), "Soluta at magnam.", false, null, 1, "Exame de Sangue" },
                    { new Guid("68819003-1466-4957-955b-194a1f0d7840"), "Voluptas ducimus maiores dolores odio possimus quia.", false, null, 1, "Raio-X" },
                    { new Guid("6d31ba5e-f7a1-41c0-bfae-5b4d497e464e"), "Qui molestiae ratione minus exercitationem praesentium sint vitae.", false, null, 1, "MRI" },
                    { new Guid("6e082bb1-5b70-418b-9071-045c462f539e"), "Tempore ea possimus.", false, null, 1, "Exame de Sangue" },
                    { new Guid("73a7936f-7531-4e69-86c7-217317d7e683"), "Consequatur sed dolores sunt recusandae nobis exercitationem et suscipit vel.", false, null, 1, "Raio-X" },
                    { new Guid("77c5be1b-eb8f-4d9b-9fe9-d2ae703b4629"), "Non occaecati minus vero.", false, null, 1, "MRI" },
                    { new Guid("78a8b5e9-8b29-4d46-b1c3-3c83cb6467ee"), "Quia fuga sed et est minima placeat explicabo quo labore.", false, null, 1, "Raio-X" },
                    { new Guid("7c5d99eb-8ab0-44d7-8997-e20e18e0de6a"), "A minima vero provident repellendus voluptatibus eos.", false, null, 1, "Exame de Sangue" },
                    { new Guid("7d83b481-ca67-4b5b-9b94-df15243bea26"), "Aliquam quod dolores et enim corrupti nobis perspiciatis omnis.", false, null, 1, "MRI" },
                    { new Guid("8151b863-be5a-4a77-94d2-590e127c0aed"), "Magni enim provident sequi eos natus.", false, null, 1, "Exame de Sangue" },
                    { new Guid("82b2a103-1bb0-438d-b9dd-4087d9b784fb"), "Consequuntur sit sunt error consequatur quisquam soluta aut eaque.", false, null, 1, "Exame de Sangue" },
                    { new Guid("880682f0-692a-4043-baa5-712924a00586"), "Aperiam quisquam totam facilis est earum molestiae et facilis voluptatem.", false, null, 1, "MRI" },
                    { new Guid("8ac42f50-4e29-4910-89ab-f38f4dafad7d"), "Officia fugiat magnam sed itaque molestiae rem illo aut autem.", false, null, 1, "Raio-X" },
                    { new Guid("8c6b2032-4c16-4d85-83f0-d9c44c64a03d"), "Maiores placeat doloribus doloribus vitae ut necessitatibus.", false, null, 1, "Exame de Sangue" },
                    { new Guid("8fa45b11-8913-47aa-a1f7-34bc5ac97071"), "Molestiae quod facilis.", false, null, 1, "MRI" },
                    { new Guid("90107e25-c950-4cc0-8064-aac95920f2ec"), "Et sunt explicabo ipsam rerum at vel ipsum.", false, null, 1, "Raio-X" },
                    { new Guid("9816366e-8cb0-492e-8de5-d82f5f25b411"), "At quo ducimus consequatur.", false, null, 1, "Raio-X" },
                    { new Guid("981c8397-392f-439e-92e9-0f4b5acfa39f"), "Ut magnam commodi eos quidem ea non labore.", false, null, 1, "MRI" },
                    { new Guid("98e8ef0f-f0f0-4189-acba-f906630cf68f"), "Ratione omnis unde.", false, null, 1, "MRI" },
                    { new Guid("99b0c151-bfde-403f-bc39-65d1ca973472"), "Laudantium veniam ut possimus officiis nihil quia.", false, null, 1, "Raio-X" },
                    { new Guid("9aae2167-d0a8-43bc-a376-7be14e8f306e"), "Aut et quas est labore totam porro.", false, null, 1, "Raio-X" },
                    { new Guid("9b0218d4-c9fc-4128-8b89-57d71e35c1fd"), "Laudantium fuga maiores odit non dicta.", false, null, 1, "Raio-X" },
                    { new Guid("9f9983a1-997b-402a-81a4-7877a03cefbe"), "Sapiente ut dolores eveniet dolores recusandae minima est.", false, null, 1, "Exame de Sangue" },
                    { new Guid("a187f601-3b07-4ed2-a0ed-0019e33a8b66"), "Architecto iure rerum.", false, null, 1, "MRI" },
                    { new Guid("a1e52ea0-f84c-495a-8d59-1c77bfc6f0b0"), "Sit recusandae ea id saepe magni qui velit.", false, null, 1, "Exame de Sangue" },
                    { new Guid("a4295a05-ba63-4b6a-a901-71d72d5f3b08"), "Cum facilis autem facilis beatae pariatur rerum aut ipsam omnis.", false, null, 1, "Exame de Sangue" },
                    { new Guid("a5636154-133b-4ee3-b5f3-83fa1310c2d2"), "Est odit reiciendis.", false, null, 1, "MRI" },
                    { new Guid("a5e42b38-be82-40bd-9d42-0284a90a9a10"), "Maxime quia dolorem quae tenetur blanditiis et architecto nulla.", false, null, 1, "MRI" },
                    { new Guid("a6c933c1-5c48-46b1-84cd-a4b6b18ad174"), "Quo qui omnis est voluptatem ipsum eveniet libero.", false, null, 1, "Raio-X" },
                    { new Guid("a7573608-36e6-49b0-bc0d-34d2a4e795c0"), "Quia beatae quidem consequatur ut rerum possimus beatae.", false, null, 1, "MRI" },
                    { new Guid("a76a55e6-a742-4ee9-8072-58f8d621e2af"), "Ab laboriosam asperiores vitae molestiae nihil enim saepe sint.", false, null, 1, "Raio-X" },
                    { new Guid("ab4754c2-1c6a-4b24-a265-437a6df3fe39"), "Voluptas suscipit laboriosam vel dolor repudiandae libero.", false, null, 1, "MRI" },
                    { new Guid("ac4b1645-115b-4438-b523-d8475799594d"), "Nisi itaque perspiciatis et facilis sed.", false, null, 1, "MRI" },
                    { new Guid("afcedad4-bc83-4fbf-b023-ec7e0fa071aa"), "Quis omnis et.", false, null, 1, "MRI" },
                    { new Guid("b07fb5f3-daa0-488d-b5b6-5c07909aa8dc"), "Itaque reiciendis aspernatur iste tenetur est.", false, null, 1, "Exame de Sangue" },
                    { new Guid("b0b8a5da-6792-46ff-b6e1-702855b2971b"), "Voluptas ea soluta mollitia et molestiae praesentium enim molestiae dignissimos.", false, null, 1, "MRI" },
                    { new Guid("b15f45a7-ec62-44d8-9228-f7710f7f3629"), "Deserunt ex animi.", false, null, 1, "Exame de Sangue" },
                    { new Guid("b1cb470b-be7a-4adf-afdb-82d8e5b1dbe9"), "Earum iusto eligendi at.", false, null, 1, "Exame de Sangue" },
                    { new Guid("b23dcbac-5547-471e-b0ef-0af2462f9ac1"), "Corporis mollitia nemo vitae.", false, null, 1, "Raio-X" },
                    { new Guid("b44642b1-eb4f-4d48-9a90-fa9a7c61b49b"), "Et sed vitae modi occaecati placeat nulla cumque odit.", false, null, 1, "MRI" },
                    { new Guid("b5c2eaec-3f98-421e-a306-e9fc0152bddd"), "Enim assumenda nihil et eos doloremque labore id temporibus.", false, null, 1, "Raio-X" },
                    { new Guid("be21f814-f47c-49cc-8348-bb01fe551b3c"), "Quasi labore necessitatibus et id porro qui hic doloribus.", false, null, 1, "Raio-X" },
                    { new Guid("c7b77a56-f9e1-4615-a749-d7eeb43e2643"), "Laboriosam molestiae impedit dolorum molestias rerum alias recusandae sint minus.", false, null, 1, "MRI" },
                    { new Guid("c8e1534d-c82a-4375-90a3-bf74995f276e"), "Qui consequatur eos ut consequuntur harum minima ratione.", false, null, 1, "MRI" },
                    { new Guid("c9e7675d-457b-413d-8cb5-7cb8ca9ea2a2"), "Itaque deserunt natus distinctio eaque molestiae et dignissimos aut dolorum.", false, null, 1, "MRI" },
                    { new Guid("caf6d07e-7dff-4577-9b12-eb90cde04ff1"), "Magni ea suscipit dignissimos molestias est et ea eum id.", false, null, 1, "Raio-X" },
                    { new Guid("cc1f4bd3-6e8d-4580-957d-27e301c1adc2"), "Dolor sed eum.", false, null, 1, "Exame de Sangue" },
                    { new Guid("cd5a137d-9054-47a2-af99-d1fcd6b9cf67"), "Rem illum quis voluptate similique veniam aspernatur.", false, null, 1, "Exame de Sangue" },
                    { new Guid("d192327e-28bb-412e-a40a-a74c4620be22"), "Autem voluptatibus aliquam nulla non vero.", false, null, 1, "MRI" },
                    { new Guid("d9374e28-e63d-44c7-a1ae-e89555d8d56b"), "Eligendi commodi officia autem.", false, null, 1, "Exame de Sangue" },
                    { new Guid("d9efcd43-67dd-4c31-9f16-31fa7351e43c"), "Voluptatibus nam necessitatibus repellendus voluptas.", false, null, 1, "MRI" },
                    { new Guid("dc999195-f992-4945-80bf-b9341c91dd66"), "Rerum est aut consectetur qui.", false, null, 1, "Raio-X" },
                    { new Guid("dcd90102-cae3-4f92-be33-66bc7c5b2f2f"), "Quia nihil repellat dignissimos ea sit dolor.", false, null, 1, "Raio-X" },
                    { new Guid("dd2d38f0-d763-41ff-b94e-4f0763d3f845"), "Est hic nostrum ab blanditiis quidem.", false, null, 1, "Exame de Sangue" },
                    { new Guid("df567dd6-18d4-4a3d-9295-bf17d08c6cf8"), "Quod eum rerum inventore iste repudiandae et magni nisi deserunt.", false, null, 1, "Exame de Sangue" },
                    { new Guid("df5f2471-b567-4967-bf2f-5cef2b3ebe75"), "Et quia consectetur odio totam qui cupiditate minus sit.", false, null, 1, "MRI" },
                    { new Guid("e4f90665-7d0f-4072-a814-5a33f332547e"), "Rem ex rerum placeat nisi eum hic facilis et et.", false, null, 1, "MRI" },
                    { new Guid("e51c0d2f-11ab-4476-9f6d-8a6831bbb0a3"), "Ad rerum quia voluptatem voluptatem quod quia ab.", false, null, 1, "MRI" },
                    { new Guid("e73bf6fa-11f8-4b4c-b742-09a093fe97c5"), "Est quo reprehenderit voluptatibus accusantium qui nam harum.", false, null, 1, "Exame de Sangue" },
                    { new Guid("e9e3703e-93d8-4254-9165-2c5b56db19e0"), "Quia distinctio quia reiciendis rerum eius qui quaerat.", false, null, 1, "Raio-X" },
                    { new Guid("ea300edd-94fb-42be-9bdb-92f950f8046c"), "Reprehenderit deserunt sed repellendus omnis sed.", false, null, 1, "Exame de Sangue" },
                    { new Guid("eaf71781-3a64-4389-adf2-786b6b8ea29e"), "Odio eum eos aspernatur in alias ad.", false, null, 1, "MRI" },
                    { new Guid("ed1824f1-e97c-4cdd-b17c-c93598f3fc6d"), "Omnis fugit rerum omnis ut quis sint.", false, null, 1, "Raio-X" },
                    { new Guid("f8b84b73-7dc0-4154-8118-9d6e23d701e1"), "Ea in nam dolor commodi nostrum omnis qui.", false, null, 1, "MRI" },
                    { new Guid("f92fd6c7-ee72-42c2-83b4-76c33e73a2b4"), "Facere voluptas et occaecati eaque cumque quis est.", false, null, 1, "Exame de Sangue" },
                    { new Guid("fe873513-4fac-42c2-9742-1b9c3f6f8405"), "Mollitia quod ipsa voluptas tempore amet maxime.", false, null, 1, "MRI" },
                    { new Guid("fefa02b1-15a1-4863-ac37-128805cd7fab"), "Eaque architecto eligendi culpa.", false, null, 1, "MRI" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exams");
        }
    }
}
