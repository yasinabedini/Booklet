namespace Beginning.MiddleWareAndRouting
{
    public class checkendpoint
    {
        private readonly RequestDelegate next;

        public checkendpoint(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var enpoint = context.GetEndpoint();
            context.Response.WriteAsync(enpoint.DisplayName);
        }
    }
}
