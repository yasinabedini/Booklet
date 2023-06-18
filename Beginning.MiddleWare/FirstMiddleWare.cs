namespace Beginning.MiddleWare
{
    public class FirstMiddleWare
    {
        private readonly RequestDelegate next;
        
        public FirstMiddleWare(RequestDelegate next)
        {
            this.next = next;
        }
        public FirstMiddleWare()
        {

        }

        public async Task InvokeAsync(HttpContext context)
        {            
            if (next != null) next(context);
        }

    }
}
