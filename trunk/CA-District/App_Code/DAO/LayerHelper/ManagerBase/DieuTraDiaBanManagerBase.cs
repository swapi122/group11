




/*
'===============================================================================
'  LayerHelper.CAQ.BL.DieuTraDiaBanManagerBase
'===============================================================================
*/

using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using LayerHelper.CAQ.BLL;
using LayerHelper.CAQ.DAL;
using LayerHelper.CAQ.DAL.EntityClasses;
using LayerHelper.CAQ.DAL.FactoryClasses;
using LayerHelper.CAQ.DAL.HelperClasses;
using SD.LLBLGen.Pro.ORMSupportClasses;

namespace LayerHelper.CAQ.BLL
{
	public class DieuTraDiaBanManagerBase
	{
		/// <summary>
		/// Purpose: Class constructor.
		/// </summary>
		public DieuTraDiaBanManagerBase()
		{
			// Nothing for now.
		}
		
		public DieuTraDiaBanEntity Insert(DieuTraDiaBanEntity _DieuTraDiaBanEntity)
		{
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.SaveEntity(_DieuTraDiaBanEntity, true);
			}
			return _DieuTraDiaBanEntity;
		}

		
		public DieuTraDiaBanEntity Insert(Guid Id, Guid IdDiaBan, DateTime NgayTienHanh, string NoiDungDieuTra, string MaRutGon, string MaTp, string GhiChu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			DieuTraDiaBanEntity _DieuTraDiaBanEntity = new DieuTraDiaBanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DieuTraDiaBanEntity.Id = Id;
				_DieuTraDiaBanEntity.IdDiaBan = IdDiaBan;
				_DieuTraDiaBanEntity.NgayTienHanh = NgayTienHanh;
				_DieuTraDiaBanEntity.NoiDungDieuTra = NoiDungDieuTra;
				_DieuTraDiaBanEntity.MaRutGon = MaRutGon;
				_DieuTraDiaBanEntity.MaTp = MaTp;
				_DieuTraDiaBanEntity.GhiChu = GhiChu;
				_DieuTraDiaBanEntity.IdNguoiTao = IdNguoiTao;
				_DieuTraDiaBanEntity.NgayTao = NgayTao;
				_DieuTraDiaBanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_DieuTraDiaBanEntity.NgayCapNhat = NgayCapNhat;
				_DieuTraDiaBanEntity.NgayHetHan = NgayHetHan;
				_DieuTraDiaBanEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_DieuTraDiaBanEntity, true);
			}
			return _DieuTraDiaBanEntity;
		}

		public DieuTraDiaBanEntity Insert(Guid IdDiaBan, DateTime NgayTienHanh, string NoiDungDieuTra, string MaRutGon, string MaTp, string GhiChu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			DieuTraDiaBanEntity _DieuTraDiaBanEntity = new DieuTraDiaBanEntity();
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				
				_DieuTraDiaBanEntity.IdDiaBan = IdDiaBan;
				_DieuTraDiaBanEntity.NgayTienHanh = NgayTienHanh;
				_DieuTraDiaBanEntity.NoiDungDieuTra = NoiDungDieuTra;
				_DieuTraDiaBanEntity.MaRutGon = MaRutGon;
				_DieuTraDiaBanEntity.MaTp = MaTp;
				_DieuTraDiaBanEntity.GhiChu = GhiChu;
				_DieuTraDiaBanEntity.IdNguoiTao = IdNguoiTao;
				_DieuTraDiaBanEntity.NgayTao = NgayTao;
				_DieuTraDiaBanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
				_DieuTraDiaBanEntity.NgayCapNhat = NgayCapNhat;
				_DieuTraDiaBanEntity.NgayHetHan = NgayHetHan;
				_DieuTraDiaBanEntity.TrangThai = TrangThai;
				adapter.SaveEntity(_DieuTraDiaBanEntity, true);
			}
			return _DieuTraDiaBanEntity;
		}

		public bool Update(DieuTraDiaBanEntity _DieuTraDiaBanEntity)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				RelationPredicateBucket filter = new RelationPredicateBucket();
				IPredicateExpression _PredicateExpression = new PredicateExpression();
				_PredicateExpression.Add(DieuTraDiaBanFields.Id == _DieuTraDiaBanEntity.Id);
					
				filter.PredicateExpression.Add(_PredicateExpression);

				adapter.UpdateEntitiesDirectly(_DieuTraDiaBanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}
		
		public bool Update(DieuTraDiaBanEntity _DieuTraDiaBanEntity, RelationPredicateBucket filter)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.UpdateEntitiesDirectly(_DieuTraDiaBanEntity, filter);
				toReturn = true;
			}
			return toReturn;
		}

		public bool Update(Guid Id, Guid IdDiaBan, DateTime NgayTienHanh, string NoiDungDieuTra, string MaRutGon, string MaTp, string GhiChu, Guid IdNguoiTao, DateTime NgayTao, Guid IdNguoiCapNhat, DateTime NgayCapNhat, DateTime NgayHetHan, bool TrangThai)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DieuTraDiaBanEntity _DieuTraDiaBanEntity = new DieuTraDiaBanEntity(Id);
				if (adapter.FetchEntity(_DieuTraDiaBanEntity))
				{
				
					_DieuTraDiaBanEntity.IdDiaBan = IdDiaBan;
					_DieuTraDiaBanEntity.NgayTienHanh = NgayTienHanh;
					_DieuTraDiaBanEntity.NoiDungDieuTra = NoiDungDieuTra;
					_DieuTraDiaBanEntity.MaRutGon = MaRutGon;
					_DieuTraDiaBanEntity.MaTp = MaTp;
					_DieuTraDiaBanEntity.GhiChu = GhiChu;
					_DieuTraDiaBanEntity.IdNguoiTao = IdNguoiTao;
					_DieuTraDiaBanEntity.NgayTao = NgayTao;
					_DieuTraDiaBanEntity.IdNguoiCapNhat = IdNguoiCapNhat;
					_DieuTraDiaBanEntity.NgayCapNhat = NgayCapNhat;
					_DieuTraDiaBanEntity.NgayHetHan = NgayHetHan;
					_DieuTraDiaBanEntity.TrangThai = TrangThai;
					adapter.SaveEntity(_DieuTraDiaBanEntity, true);
					toReturn = true;
				}
			}
			return toReturn;
		}

		public bool Delete(Guid Id)
		{
			bool toReturn = false;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DieuTraDiaBanEntity _DieuTraDiaBanEntity = new DieuTraDiaBanEntity(Id);
				if (adapter.FetchEntity(_DieuTraDiaBanEntity))
				{
					adapter.DeleteEntity(_DieuTraDiaBanEntity);
					toReturn = true;
				}
			}
			return toReturn;
		}
		
		public void DeleteAll() 
		{
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.DeleteEntitiesDirectly("DieuTraDiaBanEntity", null);
			}
		}
		
		
		public int DeleteById(Guid Id)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdDiaBan(Guid IdDiaBan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.IdDiaBan == IdDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTienHanh(DateTime NgayTienHanh)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NgayTienHanh == NgayTienHanh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNoiDungDieuTra(string NoiDungDieuTra)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NoiDungDieuTra == NoiDungDieuTra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaRutGon(string MaRutGon)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByMaTp(string MaTp)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByGhiChu(string GhiChu)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiTao(Guid IdNguoiTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayTao(DateTime NgayTao)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByIdNguoiCapNhat(Guid IdNguoiCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayCapNhat(DateTime NgayCapNhat)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByNgayHetHan(DateTime NgayHetHan)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraDiaBanEntity", filter);
			}
			return toReturn;
		}
		
		public int DeleteByTrangThai(bool TrangThai)
		{
			int toReturn = 0;
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				toReturn = adapter.DeleteEntitiesDirectly("DieuTraDiaBanEntity", filter);
			}
			return toReturn;
		}
		

		
		public DieuTraDiaBanEntity SelectOne(Guid Id)
		{
			DieuTraDiaBanEntity toReturn = null;
			using(DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				DieuTraDiaBanEntity _DieuTraDiaBanEntity = new DieuTraDiaBanEntity(Id);
				if (adapter.FetchEntity(_DieuTraDiaBanEntity))
				{
					toReturn = _DieuTraDiaBanEntity;
				}
			}
			return toReturn;
		}

		// Return DataTable
		public DataTable SelectAllRDT()
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, null, true);
			}
			return toReturn;
		}
		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectAllLST()
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, null, 0, null);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectAllLST_Paged(int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, null, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraDiaBanCollection;
		}


		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByIdLST(Guid Id)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByIdLST_Paged(Guid Id, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT(Guid Id)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdRDT_Paged(Guid Id, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.Id == Id);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByIdDiaBanLST(Guid IdDiaBan)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.IdDiaBan == IdDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByIdDiaBanLST_Paged(Guid IdDiaBan, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.IdDiaBan == IdDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdDiaBanRDT(Guid IdDiaBan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.IdDiaBan == IdDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdDiaBanRDT_Paged(Guid IdDiaBan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.IdDiaBan == IdDiaBan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByNgayTienHanhLST(DateTime NgayTienHanh)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NgayTienHanh == NgayTienHanh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByNgayTienHanhLST_Paged(DateTime NgayTienHanh, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NgayTienHanh == NgayTienHanh);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTienHanhRDT(DateTime NgayTienHanh)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NgayTienHanh == NgayTienHanh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTienHanhRDT_Paged(DateTime NgayTienHanh, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NgayTienHanh == NgayTienHanh);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByNoiDungDieuTraLST(string NoiDungDieuTra)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NoiDungDieuTra == NoiDungDieuTra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByNoiDungDieuTraLST_Paged(string NoiDungDieuTra, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NoiDungDieuTra == NoiDungDieuTra);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNoiDungDieuTraRDT(string NoiDungDieuTra)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NoiDungDieuTra == NoiDungDieuTra);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNoiDungDieuTraRDT_Paged(string NoiDungDieuTra, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NoiDungDieuTra == NoiDungDieuTra);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByMaRutGonLST(string MaRutGon)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByMaRutGonLST_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT(string MaRutGon)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaRutGonRDT_Paged(string MaRutGon, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.MaRutGon == MaRutGon);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByMaTpLST(string MaTp)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByMaTpLST_Paged(string MaTp, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT(string MaTp)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByMaTpRDT_Paged(string MaTp, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.MaTp == MaTp);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByGhiChuLST(string GhiChu)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByGhiChuLST_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT(string GhiChu)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByGhiChuRDT_Paged(string GhiChu, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.GhiChu == GhiChu);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByIdNguoiTaoLST(Guid IdNguoiTao)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByIdNguoiTaoLST_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT(Guid IdNguoiTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiTaoRDT_Paged(Guid IdNguoiTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.IdNguoiTao == IdNguoiTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByNgayTaoLST(DateTime NgayTao)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByNgayTaoLST_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT(DateTime NgayTao)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayTaoRDT_Paged(DateTime NgayTao, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NgayTao == NgayTao);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByIdNguoiCapNhatLST(Guid IdNguoiCapNhat)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByIdNguoiCapNhatLST_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT(Guid IdNguoiCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByIdNguoiCapNhatRDT_Paged(Guid IdNguoiCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.IdNguoiCapNhat == IdNguoiCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByNgayCapNhatLST(DateTime NgayCapNhat)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByNgayCapNhatLST_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT(DateTime NgayCapNhat)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayCapNhatRDT_Paged(DateTime NgayCapNhat, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NgayCapNhat == NgayCapNhat);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByNgayHetHanLST(DateTime NgayHetHan)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByNgayHetHanLST_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT(DateTime NgayHetHan)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByNgayHetHanRDT_Paged(DateTime NgayHetHan, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.NgayHetHan == NgayHetHan);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByTrangThaiLST(bool TrangThai)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return EntityCollection<DieuTraDiaBanEntity>
		public EntityCollection<DieuTraDiaBanEntity> SelectByTrangThaiLST_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			EntityCollection<DieuTraDiaBanEntity> _DieuTraDiaBanCollection = new EntityCollection<DieuTraDiaBanEntity>();
			RelationPredicateBucket filter = new RelationPredicateBucket();

			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);
			
			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchEntityCollection(_DieuTraDiaBanCollection, filter, 0, null, null, PageNumber, PageSize);
			}
			return _DieuTraDiaBanCollection;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT(bool TrangThai)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, true);
			}
			return toReturn;
		}
		
		// Return DataTable
		public DataTable SelectByTrangThaiRDT_Paged(bool TrangThai, int PageNumber, int PageSize)
		{
			DataTable toReturn = new DataTable();
			EntityCollection _DieuTraDiaBanCollection = new EntityCollection(new DieuTraDiaBanEntityFactory());
			RelationPredicateBucket filter = new RelationPredicateBucket();
			
			IPredicateExpression _PredicateExpression = new PredicateExpression();
			_PredicateExpression.Add(DieuTraDiaBanFields.TrangThai == TrangThai);
			filter.PredicateExpression.Add(_PredicateExpression);

			using (DataAccessAdapterBase adapter = (new DataAccessAdapterFactory()).CreateAdapter())
			{
				adapter.FetchTypedList(_DieuTraDiaBanCollection.EntityFactoryToUse.CreateFields(), toReturn, filter, 0, null, true, null, PageNumber, PageSize);
			}
			return toReturn;
		}


		
		

	}
}
