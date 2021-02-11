using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Store.Domain.Entities;
using Store.Domain.Queries;
using Store.Tests.Repositories;

namespace Store.Tests.Queries
{
    [TestClass]
    public class ProductQueriesTests
    {
        private IEnumerable<Product> _products = new List<Product>();
        private FakeProductRepository _fakeProductRepository = new FakeProductRepository();
        private IList<Guid> ids = new List<Guid>();
       

        public ProductQueriesTests()
        {
            ids.Add(Guid.NewGuid());
            ids.Add(Guid.NewGuid());

            _products = _fakeProductRepository.Get(ids);
        }

        [TestMethod]
        [TestCategory("Domain")]
        public void DadoAConsultaDeProdutosAtivosDeveRetornar3()
        {
            var result = _products.AsQueryable().Where(ProductQueries.GetActiveProducts());
            Assert.AreEqual(result.Count(), 3);
        }
        
        [TestMethod]
        [TestCategory("Domain")]
        public void DadoAConsultaDeProdutosInativosDeveRetornar2()
        {
            var result = _products.AsQueryable().Where(ProductQueries.GetInactiveProducts());
            Assert.AreEqual(result.Count(), 2);
        }
    }
}